using Newtonsoft.Json;

namespace LeetWars.Core.WebAPI.Middlewares
{
    public class UserIdSetterMiddleware
    {
        private readonly RequestDelegate _next;

        public UserIdSetterMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var userId = context.User.Claims.FirstOrDefault(c => c.Type == "user_id")?.Value;
            
            if (userId != null)
            {
                userIdSetter.SetUserId(userId);
            }

            await _next.Invoke(context);
        }
    }
}
