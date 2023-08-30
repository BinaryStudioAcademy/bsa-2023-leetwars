using AutoMapper;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeetWars.Core.BLL.Services;

public class UserService : BaseService, IUserService
{
    public UserService(LeetWarsCoreContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<UserDto> CreateUserAsync(NewUserDto userDto)
    {
        if (userDto is null)
        {
            throw new ArgumentNullException(nameof(userDto));
        }

        var user = await _context.Users.FirstOrDefaultAsync(u => u.Uid == userDto.Uid);
        if (user != null)
        {
            return _mapper.Map<UserDto>(user);
        }
        
        var newUser = _mapper.Map<NewUserDto, User>(userDto);
        var createdUser = _context.Users.Add(newUser).Entity;
        await _context.SaveChangesAsync();
        
        return _mapper.Map<UserDto>(createdUser);
    }

    public async Task<UserFullDto> GetFullUserAsync(int id)
    {
        var user = await _context.Users.Where(u => u.Id == id)
            .Include(user => user.LanguagesWithLevels)
            .Include(user => user.PreferredLanguages)
            .Include(user => user.Solutions)
            .Include(user => user.Challenges)
            .FirstOrDefaultAsync();
       if(user is null)
        {
            throw new ArgumentNullException(id.ToString(),"Not found");
        }
        return _mapper.Map<User,UserFullDto>(user);
    }
}
