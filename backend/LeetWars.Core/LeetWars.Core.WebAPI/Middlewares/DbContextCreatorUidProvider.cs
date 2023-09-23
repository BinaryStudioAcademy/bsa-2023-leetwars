using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Interfaces;

namespace LeetWars.Core.WebAPI.Middlewares
{
    public class DbContextCreatorUidProvider
    {
        private readonly RequestDelegate _next;

        public DbContextCreatorUidProvider(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IUidProvider userUidProvider)
        {
            var userId = context.User.Claims.FirstOrDefault(c => c.Type == "user_id")?.Value;

            if (userId is not null)
            {
                userUidProvider.SetUserUid(userId);
            }

            await _next.Invoke(context);
        }
    }
}
