using LeetWars.Core.Common.DTO.Notifications;

namespace LeetWars.Notifier.WebAPI.Hubs.Interfaces
{
    public interface INotificationsHubClient
    {
        Task SendNotificationAsync(NewNotificationDto newNotification);
    }
}
