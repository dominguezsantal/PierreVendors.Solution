using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace StoreVendors
{
public class Startup
{
    public Startup(Microsoft.AspNetCore.Hosting.IWebHostEnvironment env)
    {
    var builder = new ConfigurationBuilder()
        .SetBasePath(env.ContentRootPath)
        .AddEnvironmentVariables();
    Configuration = builder.Build();
    }

    public IConfigurationRoot Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
    services.AddMvc(option => option.EnableEndpointRouting = false);
    }

    public void Configure(IApplicationBuilder app)
    {
    app.UseStaticFiles();

    app.UseDeveloperExceptionPage();

    app.UseMvc(routes =>
    {
        routes.MapRoute(
        name: "default",
        template: "{controller=Home}/{action=Index}/{id?}");
    });

    app.Run(async (context) =>
    {
        await context.Response.WriteAsync("Something went wrong!");
    });

    }
}
}
