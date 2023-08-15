using System;
using Examples.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Examples
{


    public class Program
    {


        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

            builder.Services.AddSession(options => { options.IdleTimeout = TimeSpan.FromMinutes(15); });
            builder.Services.AddSingleton<CitiesService, CitiesService>();
            

            // Add services to the container.
            var app = builder.Build();
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();

            app.MapRazorPages();

            app.Run();
        }
    }
}
