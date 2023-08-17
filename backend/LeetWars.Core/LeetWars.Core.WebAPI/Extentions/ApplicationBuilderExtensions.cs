using LeetWars.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace LeetWars.Core.WebAPI.Extentions
{
    public static class ApplicationBuilderExtensions
    {
        public static void UseCodiCoreContext(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
            using var context = scope?.ServiceProvider.GetRequiredService<LeetWarsCoreContext>();
            context?.Database.Migrate();
        }
    }
}
