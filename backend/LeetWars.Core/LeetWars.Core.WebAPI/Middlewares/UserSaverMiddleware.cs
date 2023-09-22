using LeetWars.Core.BLL.Interfaces;
using Microsoft.AspNetCore.Http;

namespace LeetWars.Core.WebAPI.Middlewares
{
    public class UserSaverMiddleware
    {
        private readonly RequestDelegate _next;

        public UserSaverMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IUserSetter userSetter)
        {
            var userId = context.User.Claims.FirstOrDefault(c => c.Type == "user_id")?.Value;
            
            if (userId is not null)
            {
                await userSetter.SetUserIdAsync(userId);
            }

            await _next.Invoke(context);
        }
    }
}
