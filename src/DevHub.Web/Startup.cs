using EPiServer.Cms.UI.AspNetIdentity;
using EPiServer.Data;
using EPiServer.DependencyInjection;
using EPiServer.Scheduler;
using EPiServer.Web.Routing;

namespace DevHub.Web;

public class Startup(IWebHostEnvironment env)
{
    public void ConfigureServices(IServiceCollection services)
    {
        if (env.IsDevelopment())
        {
            // Aspire gives us an empty database: let the CMS create its tables on first start.
            // In real environments the schema is created/upgraded as a deployment step instead.
            services.Configure<DataAccessOptions>(o => o.CreateDatabaseSchema = true);
            services.Configure<SchedulerOptions>(o => o.Enabled = false);
        }

        services
            .AddCmsAspNetIdentity<ApplicationUser>()   // local editor/admin logins until Opti ID dev keys are available
            .AddCms()
            .AddAdminUserRegistration()                // first visit to the CMS lets you create the first admin
            .AddEmbeddedLocalization<Startup>();
   
    }

    public void Configure(IApplicationBuilder app)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapContent();
            endpoints.MapDefaultEndpoints(env);   // /health and /alive for Aspire (Development only)
        });
    }
}
