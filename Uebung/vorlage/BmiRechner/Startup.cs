using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BmiRechner.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BmiRechner
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
 
        public void ConfigureServices(IServiceCollection services)
        { 
<<<<<<<< HEAD:Uebung/vorlage/BmiRechner/Startup.cs
            services.AddMvc(); 
========
            services.AddMvc();
            services.AddSingleton<IBmiService, BmiService>();
>>>>>>>> 16e7602f6f730744707afc7f58c07ca04ff6563a:Uebung/loesung/BmiRechner/Startup.cs
        }
         
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {         
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
