using LeetWars.Core.BLL.Interfaces;

namespace LeetWars.Core.WebAPI.Middlewares
{
    public class UserIdSaverMiddleware
    {
        private readonly RequestDelegate _next;

        public UserIdSaverMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IUserIdSetter userIdSetter)
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
