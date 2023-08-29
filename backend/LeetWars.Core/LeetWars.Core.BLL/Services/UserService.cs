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

        bool isExistingEmail = await CheckIsExistingEmail(userDto.Email);
        if (isExistingEmail)
        {
            throw new InvalidOperationException($"A user with email {userDto.Email} is already registered.");
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

    public async Task<bool> CheckIsExistingEmail(string email)
    {
        bool isExistingEmail = false;

        var existingUser = await _context.Users.FirstOrDefaultAsync(u=>u.Email == email);
        if (existingUser != null)
        {
            isExistingEmail = true;
        }     

        return isExistingEmail;
    }
}
