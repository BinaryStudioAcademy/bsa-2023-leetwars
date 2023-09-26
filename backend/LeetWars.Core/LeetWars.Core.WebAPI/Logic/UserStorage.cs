using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.Exceptions;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeetWars.Core.WebAPI.Logic
{
    public class UserStorage : IUserGetter, IUserSetter
    {
        private string _id = String.Empty;
        private User? _user;
        private readonly LeetWarsCoreContext _context;

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
                throw new InvalidTokenException(_id);
            }

            return _id;
        }

        public User GetCurrentUserOrThrow()
        {
            return _user ?? throw new InvalidTokenException(_id);
        }

        public async Task SetUserIdAsync(string userId)
        {
            if (_id != userId)
            {
                _user = await GetCurrentUserEntityAsync(userId);
                _id = _user?.Uid ?? "";
            }
        }

        private async Task<User?> GetCurrentUserEntityAsync(string uid)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Uid == uid);
        }
    }
}