using LeetWars.Core.Common.DTO.CodeFight;
using LeetWars.Core.Common.DTO.Notifications;

namespace LeetWars.Notifier.WebAPI.Hubs.Interfaces
{
    public interface INotificationsHubClient
    {
        Task SendNotificationAsync(NotificationDto newNotification);
        Task StartCodeFightAsync(CodeFightStartDto codeFightDto);
        Task WinCodeFightAsync(NotificationDto newNotification);
        Task LoseCodeFightAsync(NotificationDto newNotification);
        Task CodeFightRequestAsync(CodeFightRequestNotificationDto notification);
    }
}
