using LeetWars.Core.Common.GlobalMiddlewares;
using Microsoft.AspNetCore.Builder;

namespace LeetWars.Core.Common.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<GenericExceptionHandlerMiddleware>();
        }
    }
}
