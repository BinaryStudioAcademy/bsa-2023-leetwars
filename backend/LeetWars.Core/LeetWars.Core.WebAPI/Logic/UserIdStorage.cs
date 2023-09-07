using LeetWars.Core.BLL.Interfaces;

namespace LeetWars.Core.WebAPI.Logic
{
    public class UserIdStorage : IUserIdGetter, IUserIdSetter
    {
        private string _id = String.Empty;

        public string CurrentUserId
        {
            get => _id;
        }

        public string GetCurrentUserIdOrThrow()
        {
            if (String.IsNullOrEmpty(_id))
            {
                throw new ArgumentException("No token with userId was passed");
            }

            return _id;
        }

        public void SetUserId(string userId)
        {
            _id = userId;
        }
    }
}