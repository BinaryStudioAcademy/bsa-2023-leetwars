using AutoMapper;
using LeetWars.Core.BLL.Exceptions;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.CodeFight;
using LeetWars.Core.Common.DTO.Notifications;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Enums;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LeetWars.Core.BLL.Services
{
    public class CodeFightService : BaseService, ICodeFightService
    {
        private readonly INotificationSenderService _notificationSenderService;
        private readonly IUserService _userService;
        private readonly IChallengeService _challengeService;

        private const long NOTIFICATION_CODE_FIGHT_TIME = 10 * 1000;

        public CodeFightService(LeetWarsCoreContext context, IMapper mapper, INotificationSenderService notificationSenderService, IUserService userService, IChallengeService challengeService)
            : base(context, mapper)
        {
            _notificationSenderService = notificationSenderService;
            _userService = userService;
            _challengeService = challengeService;
        }

        public async Task<List<UserDto>> SendCodeFightRequestStartedAsync(CodeFightRequestDto requestDto)
        {
            var challenge = await _challengeService.GetCodeFightChallengeAsync(requestDto.ChallengeSettings);

            var language = await _context.Languages.FirstAsync(language => language.Id == requestDto.ChallengeSettings.LanguageId);

            var sender = await _userService.GetBriefUserInfoByIdAsync(requestDto.SenderId);

            var notification = new NewNotificationDto
            {
                DateSending = DateTime.UtcNow,
                ReceiverId = requestDto.ReceiverId.ToString(),
                Sender = sender,
                Challenge = challenge,
                TypeNotification = TypeNotifications.CodeFightRequestStart,
                Message = $"You received code fight from {sender.UserName}! {requestDto.ChallengeSettings.Level} challenge from " +
                $"{language.Name}. Are you in?",
                ShowFor = NOTIFICATION_CODE_FIGHT_TIME
            };

            return await UpdateUsersCodeFightStatusesAsync(notification, CodeFightStatus.HasRequest);
        }

        public async Task<List<UserDto>> SendcodeFightRequestEndedAsync(NewNotificationDto notification)
        {
            notification.TypeNotification = TypeNotifications.CodeFightRequestEnd;

            if (notification.ReceiverId is null || notification.Sender is null)
            {
                throw new NotFoundException(nameof(NewNotificationDto));
            }

            long receiverId = long.Parse(notification.ReceiverId);

            var sender = await _userService.GetUserAsync(notification.Sender.Id);
            var receiver = await _userService.GetUserAsync(receiverId);

            if (sender.CodeFightStatus == CodeFightStatus.HasRequest)
            {
                return await UpdateUsersCodeFightStatusesAsync(notification, CodeFightStatus.NotInBattle);
            }

            return new List<UserDto> { sender, receiver };
        }

        public async Task<List<UserDto>> SendCodeFightStartAsync(NewNotificationDto notificationDto)
        {
            notificationDto.TypeNotification = TypeNotifications.CodeFightStart;

            if (notificationDto.Challenge is null
                || notificationDto.Sender is null
                || string.IsNullOrEmpty(notificationDto.ReceiverId))
            {
                throw new NotFoundException(nameof(NewNotificationDto));
            }

            var codeFight = new CodeFight
            {
                ChallengeId = notificationDto.Challenge.Id,
                ReceiverId = long.Parse(notificationDto.ReceiverId),
                SenderId = notificationDto.Sender.Id,
            };

            await _context.AddAsync(codeFight);
            await _context.SaveChangesAsync();

            return await UpdateUsersCodeFightStatusesAsync(notificationDto, CodeFightStatus.InBattle);
        }

        public async Task<List<UserDto>> SendCodeFightEndAsync(CodeFightEndDto codeFightEndDto)
        {
            var senderCodeFight = await GetCodeFightChallengeByExpressionAsync(cf => cf.SenderId == codeFightEndDto.SenderId);
            var receiverCodeFight = await GetCodeFightChallengeByExpressionAsync(cf => cf.ReceiverId == codeFightEndDto.SenderId);

            var codeFight = senderCodeFight ?? receiverCodeFight;

            bool isWinner = codeFightEndDto.IsWinner
                ? codeFightEndDto.IsWinner && senderCodeFight is not null
                : receiverCodeFight is not null;

            if (codeFight is null)
            {
                throw new NotFoundException(nameof(CodeFight));
            }

            var challenge = await _challengeService.GetBriefChallengeInfoByIdAsync(codeFight.ChallengeId);

            var sender = await _userService.GetBriefUserInfoByIdAsync(codeFight.SenderId);
            var receiver = await _userService.GetBriefUserInfoByIdAsync(codeFight.ReceiverId);

            _context.Remove(codeFight);

            var editUserDto = new EditUserDto
            {
                CompletedChallengeId = challenge.Id,
                Id = isWinner ? sender.Id : receiver.Id
            };

            await _userService.UpdateUserRankAsync(editUserDto);

            await _context.SaveChangesAsync();

            var notification = new NewNotificationDto
            {
                TypeNotification = TypeNotifications.CodeFightEnd,
                Challenge = challenge,
                ReceiverId = isWinner ? receiver.Id.ToString() : sender.Id.ToString(),
                DateSending = DateTime.UtcNow,
                Sender = isWinner ? sender : receiver,
            };

            return await UpdateUsersCodeFightStatusesAsync(notification, CodeFightStatus.NotInBattle);
        }

        private async Task<List<UserDto>> UpdateCodeFightStatusAsync(UserCodeFightDto userCodeFightDto)
        {
            var sender = await UpdateUserStatusAsync(userCodeFightDto.SenderId, userCodeFightDto.Status);
            var receiver = await UpdateUserStatusAsync(userCodeFightDto.ReceiverId, userCodeFightDto.Status);

            _context.Users.Update(sender);
            _context.Users.Update(receiver);

            await _context.SaveChangesAsync();

            return _mapper.Map<List<UserDto>>(new List<User> { sender, receiver });
        }

        private async Task<List<UserDto>> UpdateUsersCodeFightStatusesAsync(NewNotificationDto notificationDto, CodeFightStatus newStatus)
        {
            var userCodeFight = new UserCodeFightDto
            {
                ReceiverId = long.Parse(notificationDto.ReceiverId!),
                SenderId = notificationDto.Sender!.Id,
                Status = newStatus
            };

            var users = await UpdateCodeFightStatusAsync(userCodeFight);

            _notificationSenderService.SendNotificationToRabbitMQ(notificationDto);

            return users;
        }

        private async Task<User> UpdateUserStatusAsync(long userId, CodeFightStatus status)
        {
            var user = await _context.Users.FirstOrDefaultAsync(user => user.Id == userId)
                ?? throw new NotFoundException(nameof(User), userId);

            user.CodeFightStatus = status;

            return user;
        }

        private async Task<CodeFight?> GetCodeFightChallengeByExpressionAsync(Expression<Func<CodeFight, bool>> expression)
        {
            return await _context.CodeFights
                .Include(codeFight => codeFight.Sender)
                .Include(codeFight => codeFight.Receiver)
                .FirstOrDefaultAsync(expression);
        }
    }
}
