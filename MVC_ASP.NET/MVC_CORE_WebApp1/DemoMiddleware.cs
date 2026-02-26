using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MVC_CORE_WebApp1
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class DemoMiddleware
    {
        private readonly RequestDelegate _next;

        public DemoMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {

            string[] bannedWords = { "stupid", "idiot", "badword","dog","FuckOff","dumb" };

            foreach (var param in httpContext.Request.Query)
            {
                string value = param.Value.ToString().ToLower();

                if (bannedWords.Any(word => value.Contains(word)))
                {
                    httpContext.Response.StatusCode = 400;
                    await httpContext.Response.WriteAsync("Bad words are not allowed.");
                    return;
                }
            }

            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class DemoMiddlewareExtensions
    {
        public static IApplicationBuilder UseDemoMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<DemoMiddleware>();
        }
    }
}
