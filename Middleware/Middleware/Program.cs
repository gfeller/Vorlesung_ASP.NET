using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline. 

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hello");
});



app.Run();


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

app.UseMiddleware<UseWelcomePage>();

app.UseMiddleware<RequestLoggerMiddleware>();

public class RequestLoggerMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger _logger;

    public RequestLoggerMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
    {
        _next = next;
        _logger = loggerFactory.CreateLogger<RequestLoggerMiddleware>();
    }

    public async Task Invoke(HttpContext context)
    {
        _logger.LogInformation("Handling request: " + context.Request.Path);
        await _next.Invoke(context);
        _logger.LogInformation("Finished handling request.");
    }
}
*/