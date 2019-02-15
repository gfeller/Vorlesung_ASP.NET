using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DI_Example
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddTransient<IUserService, UserService>();
            //services.AddTransient<IUserService, FakeUserService>();
            //services.AddTransient<UserContext, UserContext>(); //class class mapping is allowed
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseDeveloperExceptionPage();
            app.UseMiddleware<UserMiddleware>();
        }
    }


    public class UserMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IUserService _userService;

        public UserMiddleware(RequestDelegate next, IUserService userService) // Captive Dependency 
        {
            _next = next;
            _userService = userService;
        }

  
        public async Task Invoke(HttpContext context) // Captive Dependency 
        {
            await context.Response.WriteAsync(_userService.Users.Any() ? string.Join(", ", _userService.Users) : "None");
        }
  
        /*
        public async Task Invoke(HttpContext context,  IEnumerable<IUserService> services) // no Captive Dependency 
        {
            foreach (var service in services)
            {
                await context.Response.WriteAsync(service.GetType().Name + "\t\t\t" + (service.Users.Any() ? string.Join(", ", service.Users) : "None") + Environment.NewLine);
            }
        }
        */
        
    }


    public interface IUserService
    {
        string[] Users { get; }
    }
 
    public class UserService : IUserService
    {
        public string[] Users { get; } = {};
    } 

    public class FakeUserService : IUserService
    {
        public string[] Users { get; } = {"Michael", "Bob"};
    }

    /*
    public class UserService : IUserService
    {
        private readonly UserContext _userContext;

        public UserService(UserContext userContext)
        {
            _userContext = userContext;
        }

        public string[] Users => _userContext.LoadFromDataBase();
    }
    */
    public class UserContext
    {
        public string[] LoadFromDataBase()
        {
            return new[] {"Lisa", "Yve"};
        }
    }
}