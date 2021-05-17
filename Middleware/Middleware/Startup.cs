using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Middleware
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello");
            });


            /*
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("World");
            });
                 

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello");
                // await next.Invoke();
            });

            app.UseWelcomePage();

            app.UseWelcomePage("/hallo");

            app.Map("/hallo", builder => builder.UseWelcomePage());



            app.UseStaticFiles();

            app.UseMiddleware<RequestLoggerMiddleware>();*/
        }
    }

    public class RequestLoggerMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLoggerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            System.Diagnostics.Debug.WriteLine("Handling request: " + context.Request.Path);
            await context.Response.WriteAsync("You have been watched!");
            await _next.Invoke(context);
            System.Diagnostics.Debug.WriteLine("Finished handling request.");
        }
    }
}