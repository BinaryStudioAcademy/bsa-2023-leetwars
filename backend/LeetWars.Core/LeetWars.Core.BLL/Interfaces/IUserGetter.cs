using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.BLL.Interfaces
{
    public interface IUserGetter
    {
        /// <summary>
        /// Returns current userId or 0 if no userId is presented
        /// </summary>
        string CurrentUserId { get; }
        
        /// <summary>
         /// Returns current user or null if no user is presented
         /// </summary>
        User? CurrentUser { get; }

        /// <summary>
        /// Throws exception if not userId is presented
        /// </summary>
        /// <returns></returns>
        string GetCurrentUserIdOrThrow();
       
        /// <summary>
        /// Throws exception if not user is presented
        /// </summary>
        /// <returns></returns>
        User GetCurrentUserOrThrow();
    }
}
