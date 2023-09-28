using AutoMapper;
using LeetWars.Core.BLL.Exceptions;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.Friendship;
using LeetWars.Core.Common.DTO.Notifications;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Enums;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LeetWars.Core.BLL.Services
{
    public class NotificationServcie : BaseService, INotificationService
    {
        private readonly INotificationSenderService _notificationSenderService;
        private readonly IUserGetter _userGetter;
        public NotificationServcie(LeetWarsCoreContext context, IMapper mapper, INotificationSenderService notificationSenderService, IUserGetter userGetter) : base(context, mapper)
        {
            _notificationSenderService = notificationSenderService;
            _userGetter = userGetter;
        }

        public async Task CreateNotification(NotificationDto newNotification)
        {
            var notification = _mapper.Map<Notification>(newNotification);

            await _context.Notifications.AddAsync(notification);

            await _context.SaveChangesAsync();

            var receiversIds = newNotification.ReceiverId is null
                ? await _context.Users.Select(e => e.Id).ToListAsync()
                : new List<long> { long.Parse(newNotification.ReceiverId) };

            var userNotifications = receiversIds.Select(id => new UserNotification
            {
                IsRead = false,
                ReceiverId = id,
                NotificationId = notification.Id
            });

            await _context.AddRangeAsync(userNotifications);
            await _context.SaveChangesAsync();
        }

        public void SendNotification(NotificationDto newNotification)
        {
            _notificationSenderService.SendNotificationToRabbitMQ(newNotification);
        }

        public async Task<ICollection<NotificationDto>> GetNotificationsOfCurrentUserAsync()
        {
            var currUserId = _userGetter.CurrentUser?.Id ?? throw new NotFoundException("User not found");

            var notificationDtos = await _context.UserNotifications
                .Where(un => un.ReceiverId == currUserId)
                .Include(un => un.Notification)
                    .ThenInclude(n => n!.Sender)
                .Include(un => un.Notification)
                    .ThenInclude(n => n!.Challenge)
                .Include(un => un.Notification)
                    .ThenInclude(n => n!.Friendship)
                .Select(un => new NotificationDto
                {
                    Id = un.Notification!.Id,
                    TypeNotification = un.Notification.TypeNotification,
                    Sender = _mapper.Map<BriefUserInfoDto>(un.Notification.Sender),
                    Challenge = _mapper.Map<BriefChallengeInfoDto>(un.Notification.Challenge),
                    IsRead = un.IsRead,
                    ReceiverId = un.ReceiverId.ToString(),
                    Message = un.Notification.Message,
                    DateSending = un.Notification.DateSending,
                    UpdateFriendship = un.Notification.TypeNotification == TypeNotifications.FriendRequest
                        ? new UpdateFriendshipDto(un.Notification.Sender!.Id, (long)un.Notification.FriendshipId!, un.Notification.Friendship!.Status)
                        : null
                })
                .ToListAsync();

            return _mapper.Map<List<NotificationDto>>(notificationDtos);
        }

        public async Task UpdateStatusToReadByUserIdsAsync(long[] ids)
        {
            await _context.UserNotifications
                .Where(un => ids.Contains(un.ReceiverId))
                .ForEachAsync(e => e.IsRead = true);

            await _context.SaveChangesAsync();
        }
    }
}
