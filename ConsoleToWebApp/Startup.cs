using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToWebApp
{
    public class Startup
    {
        public void ConfigurationServices(IServiceCollection services)
        {

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseEndpoints(endpoint =>
            {
                endpoint.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello world!");
                });
                endpoint.MapGet("/echo/{id}", async (HttpContext context, string id) =>
                {
                    await context.Response.WriteAsync($"Hello {id}!");
                });
            });
        }
    }
}
