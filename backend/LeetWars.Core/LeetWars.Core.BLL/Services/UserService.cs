using System.Security.Claims;
using AutoMapper;
using LeetWars.Core.BLL.Helpers.Email;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace LeetWars.Core.BLL.Services;

public class UserService : BaseService, IUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IMessageSenderService _messageSenderService;

    public UserService(LeetWarsCoreContext context, 
                       IMapper mapper, 
                       IHttpContextAccessor httpContextAccessor, 
                       IMessageSenderService messageSenderService) : base(context, mapper)
    {
        _httpContextAccessor = httpContextAccessor;
        _messageSenderService = messageSenderService;
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

        var welcomeEmail = EmailGenerator.GenerateWelcomeEmail(createdUser.UserName, createdUser.Email);
        _messageSenderService.SendMessageToRabbitMQ(welcomeEmail);

        return _mapper.Map<UserDto>(createdUser);
    }

    public async Task<bool> CheckIsExistingEmail(string email)
    {
        bool isExistingEmail = await _context.Users.AnyAsync(u => u.Email.ToLower() == email.ToLower());
        return isExistingEmail;
    }

    public async Task<bool> CheckIsExistingUserName(string userName)
    {
        bool isExistingUserName = await _context.Users.AnyAsync(u => u.UserName.ToLower() == userName.ToLower());
        return isExistingUserName;
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

    public async Task<UserFullDto> GetFullUserAsync(int id)
    {
        var user = await _context.Users.Where(u => u.Id == id)
            .Include(user => user.LanguagesWithLevels)
            .Include(user => user.PreferredLanguages)
            .Include(user => user.Solutions)
            .Include(user => user.Challenges)
            .FirstOrDefaultAsync();
        if (user is null)
        {
            throw new ArgumentNullException("Not Found", new Exception("User was not found"));
        }
        return _mapper.Map<User, UserFullDto>(user);
    }
    public async Task<List<UserSolutionsGroupedBySkillLevelDto>> GetUserChallengesInfoByTags(long currentUserId)
    {

        var challenges = await _context.Challenges
            .Include(x => x.Level)
            .Include(x => x.Tags)
            .Include(challenge => challenge.Versions)
                .ThenInclude(version => version.Solutions)
                    .ThenInclude(solution => solution.User)
            .GroupBy(x => x.Level!.SkillLevel)
            .Select(x => new UserSolutionsGroupedBySkillLevelDto
            {
                TotalCount = x.Count(),
                Name = x.Key,
                TaskCountDtos = x
                    .Where(x => x.Versions.SelectMany(s => s.Solutions).Any(y => y.SubmittedAt.HasValue && y.User!.Id == currentUserId))
                    .SelectMany(y => y.Tags)
                    .GroupBy(y => y.Name)
                    .Select(y => new TaskCountDto { Name = y.Key, ChallengeCount = y.Count() }),
            })
            .ToListAsync();

        return challenges;

    }
}
