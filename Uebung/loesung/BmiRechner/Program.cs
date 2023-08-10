using BmiRechner.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BmiRechner
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<IBmiService, BmiService>();

            builder.Services.AddRazorPages().AddRazorRuntimeCompilation();


            // Add services to the container.

            var app = builder.Build();


            app.UseStaticFiles();

            app.MapRazorPages();

            app.Run();
        }
    }
}
