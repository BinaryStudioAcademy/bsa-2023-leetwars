namespace Thread.NET.Common.Logic.Abstractions
{
    public interface IUserIdGetter
    {
        /// <summary>
        /// Returns current userId or 0 if no userId is presented
        /// </summary>
        int CurrentUserId { get; }

        /// <summary>
        /// Throws exception if not userId is presented
        /// </summary>
        /// <returns></returns>
        int GetCurrentUserIdStrict();
    }
}
