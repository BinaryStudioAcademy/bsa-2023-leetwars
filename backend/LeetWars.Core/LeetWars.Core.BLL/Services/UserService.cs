using AutoMapper;
using LeetWars.Core.BLL.Exceptions;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeetWars.Core.BLL.Services
{
    internal class UserService : BaseService
    {
        public UserService(LeetWarsCoreContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<ICollection<UserDto>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();

            return _mapper.Map<ICollection<UserDto>>(users);
        }

        public async Task<UserDto> GetUserById(int id)
        {
            var user = await GetUserByIdInternal(id);
            if (user == null)
            {
                throw new NotFoundException(nameof(User), id);
            }

            return _mapper.Map<UserDto>(user);
        }


        private async Task<User> GetUserByIdInternal(int id)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}
