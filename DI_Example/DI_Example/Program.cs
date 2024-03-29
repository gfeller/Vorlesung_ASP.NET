﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DI_Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.


            // builder.Services.AddTransient<IUserService, UserService>();
            // builder.Services.AddTransient<IUserService, FakeUserService>();
            // builder.Services.AddTransient<UserContext, UserContext>();


            var app = builder.Build();

            // Configure the HTTP request pipeline. 
            
            app.UseMiddleware<UserMiddleware>();

            app.Run();
        }
    }
}
