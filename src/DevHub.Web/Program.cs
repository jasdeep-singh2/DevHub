namespace DevHub.Web;

public class Program
{
    public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

    // Keep the template's generic Host + Startup model. CMS 13 only registers its editor/admin
    // UI routes (/Optimizely/CMS) on this model: on WebApplication the site works but the editor is 404.
    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureCmsDefaults()
            .AddServiceDefaults()   // OpenTelemetry + health checks, visible in the Aspire dashboard
            .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
}
