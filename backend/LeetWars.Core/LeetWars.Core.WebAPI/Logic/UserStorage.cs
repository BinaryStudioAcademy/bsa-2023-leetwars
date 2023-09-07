using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeetWars.Core.WebAPI.Logic
{
    public class UserStorage : IUserGetter, IUserSetter
    {
        private string _id = String.Empty;
        private User? _user;
        private  readonly LeetWarsCoreContext _context;

        public UserStorage(LeetWarsCoreContext context)
        {
            _context = context;
        }

        public string CurrentUserId
        {
            get => _id;
        }
        public User? CurrentUser
        {
            get => _user;
        }

        public string GetCurrentUserIdOrThrow()
        {
            if (String.IsNullOrEmpty(_id))
            {
                throw new ArgumentException("No token with userId was passed");
            }

            return _id;
        }
        public User GetCurrentUserOrThrow()
        {
            if (_user is null)
            {
                throw new ArgumentException("No token with userId was passed");
            }

            return _user;
        }

        public async Task SetUserId(string userId)
        {
            if (_id != userId)
            {
                _id = userId;
                _user = await GetCurrentUserEntity(_id);
            }
        }
        
        private async Task<User> GetCurrentUserEntity(string id)
        {
            return await _context.Users.FirstAsync(u => u.Uid == id);
        }

    }
}