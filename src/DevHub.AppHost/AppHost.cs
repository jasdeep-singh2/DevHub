var builder = DistributedApplication.CreateBuilder(args);

// Optimizely CMS 13 needs SQL Server 2022 (or Azure SQL); Postgres isn't supported.
var sql = builder.AddSqlServer("sql")
                 .WithDataVolume()                              // content survives container restarts
                 .WithLifetime(ContainerLifetime.Persistent);   // SQL Server is slow to start: keep it running between AppHost runs

// "EPiServerDB" is the connection string name the CMS looks for.
var cmsDb = sql.AddDatabase("EPiServerDB", databaseName: "devhub");

builder.AddProject<Projects.DevHub_Web>("cms")
       .WithReference(cmsDb)
       .WaitFor(cmsDb)
       .WithExternalHttpEndpoints();

builder.Build().Run();
