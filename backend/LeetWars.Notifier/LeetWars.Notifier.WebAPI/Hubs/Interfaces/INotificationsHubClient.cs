using LeetWars.Core.Common.DTO.CodeFight;
using LeetWars.Core.Common.DTO.Notifications;

namespace LeetWars.Notifier.WebAPI.Hubs.Interfaces
{
    public interface INotificationsHubClient
    {
        Task SendNotificationAsync(NewNotificationDto newNotification);
        Task StartCodeFightAsync(CodeFightStartDto codeFightDto);
        Task WinCodeFightAsync(NewNotificationDto newNotification);
        Task LoseCodeFightAsync(NewNotificationDto newNotification);
    }
}
