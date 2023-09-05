using System.Security.Claims;
using AutoMapper;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace LeetWars.Core.BLL.Services;

public class UserService : BaseService, IUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    public UserService(LeetWarsCoreContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(context, mapper)
    {
        _httpContextAccessor = httpContextAccessor;
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

        bool isExistingEmail = await CheckIsExistingEmail(userDto.Email);
        if (isExistingEmail)
        {
            throw new InvalidOperationException($"A user with email {userDto.Email} is already registered.");
        }
        
        var newUser = _mapper.Map<NewUserDto, User>(userDto);
        var createdUser = _context.Users.Add(newUser).Entity;
        await _context.SaveChangesAsync();
        
        return _mapper.Map<UserDto>(createdUser);
    }

    public async Task<bool> CheckIsExistingEmail(string email)
    {
        bool isExistingEmail = await _context.Users.AnyAsync(u => u.Email.ToLower() == email.ToLower());
        return isExistingEmail;
    }

    public async Task<UserDto> GetUserByUidAsync(string uid)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Uid == uid)
            ?? throw new InvalidOperationException($"A user with uid {uid} is not found.");
        
        return _mapper.Map<UserDto>(user);
    }

    public string GetCurrentUserUid()
    {
        return _httpContextAccessor.HttpContext?.User.Claims.First(i => i.Type == ClaimTypes.NameIdentifier).Value!;
    }
}
