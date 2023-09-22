using LeetWars.Core.Common.DTO.CodeFight;
using LeetWars.Core.Common.DTO.Notifications;

namespace LeetWars.Notifier.WebAPI.Hubs.Interfaces
{
    public interface INotificationsHubClient
    {
        Task SendNotification(NewNotificationDto newNotification);
        Task StartCodeFight(CodeFightStartDto codeFightDto);
    }
}
