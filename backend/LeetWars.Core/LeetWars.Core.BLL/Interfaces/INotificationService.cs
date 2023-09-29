using LeetWars.Core.Common.DTO.Filters;
using LeetWars.Core.Common.DTO.Notifications;
using LeetWars.Core.Common.DTO.SortingModel;

namespace LeetWars.Core.BLL.Interfaces
{
    public interface INotificationService
    {
        Task CreateNotification(NotificationDto newNotification);
        void SendNotification(NotificationDto newNotification);
        Task<ICollection<NotificationDto>> GetNotificationsOfCurrentUserAsync(PageSettingsDto? page);
        Task UpdateStatusToReadByUserIdsAsync(long[] ids);
        int GetCountOfUserUnreadNotifications();
    }
}
