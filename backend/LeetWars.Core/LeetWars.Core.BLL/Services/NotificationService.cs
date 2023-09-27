using AutoMapper;
using LeetWars.Core.BLL.Exceptions;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.Notifications;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

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

            _context.Notifications.Add(notification);

            await _context.SaveChangesAsync();

            if(newNotification.ReceiverId is null)
            {
                var allIds = _context.Users.Select(e => e.Id);
                foreach(var id in allIds)
                {
                    _context.UserNotifications.Add(new UserNotification
                    {
                        IsRead = false,
                        ReceiverId = id,
                        NotificationId = notification.Id
                    });
                }
            }
            else
            {
                _context.UserNotifications.Add(new UserNotification
                {
                    IsRead = false,
                    ReceiverId = int.Parse(newNotification.ReceiverId),
                    NotificationId = notification.Id
                });
            }
            await _context.SaveChangesAsync();
        }

        public void SendNotification(NotificationDto newNotification)
        {
            _notificationSenderService.SendNotificationToRabbitMQ(newNotification);
        }

        public async Task<ICollection<NotificationDto>> GetNotificationsOfCurrentUserAsync()
        {
            var currUserId = _userGetter.CurrentUser?.Id;

            if (currUserId is null)
            {
                throw new NotFoundException("User not found");
            }

            var notificationDtos = await _context.UserNotifications
                .Where(un => un.ReceiverId == currUserId)
                .Include(un => un.Notification)
                    .ThenInclude(n => n!.Sender)
                .Include(un => un.Notification)
                    .ThenInclude(n => n!.Challenge)
                .Select(un => new NotificationDto
                {
                    Id = un.Notification!.Id,
                    TypeNotification = un.Notification.TypeNotification,
                    Sender = _mapper.Map<BriefUserInfoDto>(un.Notification.Sender),
                    Challenge = _mapper.Map<BriefChallengeInfoDto>(un.Notification.Challenge),
                    IsRead = un.IsRead,
                    ReceiverId = un.ReceiverId.ToString(),
                    Message = un.Notification.Message,
                    DateSending = un.Notification.DateSending
                })
                .ToListAsync();

            return _mapper.Map<List<NotificationDto>>(notificationDtos);
        }

        public async Task UpdateStatusToRead(long[] ids)
        {
            var currUserId = _userGetter.CurrentUser?.Id;

            if (currUserId is null)
            {
                throw new NotFoundException("User not found");
            }

            await _context.UserNotifications
                .Where(un => ids.Contains(un.NotificationId) && un.ReceiverId == currUserId)
                .ForEachAsync(e => e.IsRead = true);

            await _context.SaveChangesAsync();
        }
    }
}
