using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Middleware
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            
            var app = builder.Build();

            // Configure the HTTP request pipeline. 

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



            app.Run();
        }
    }
}
