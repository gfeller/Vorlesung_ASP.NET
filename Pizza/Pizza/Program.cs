using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pizza.Data;


namespace Pizza
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddMvc();
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("Pizza"));

            var app = builder.Build();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            
            app.MapRazorPages();

            app.Run();
        }
    }
}
