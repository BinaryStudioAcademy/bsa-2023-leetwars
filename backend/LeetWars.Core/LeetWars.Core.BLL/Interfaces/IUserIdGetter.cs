namespace LeetWars.Core.BLL.Interfaces
{
    public interface IUserIdGetter
    {
        /// <summary>
        /// Returns current userId or 0 if no userId is presented
        /// </summary>
        string CurrentUserId { get; }

        /// <summary>
        /// Throws exception if not userId is presented
        /// </summary>
        /// <returns></returns>
        string GetCurrentUserIdOrThrow();
    }
}
