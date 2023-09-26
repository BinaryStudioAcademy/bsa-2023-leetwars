using LeetWars.Core.Common.DTO.Notifications;

namespace LeetWars.Core.BLL.Interfaces
{
    public interface INotificationService
    {
        Task CreateNotification(NotificationDto newNotification);
        void SendNotification(NotificationDto newNotification);
        Task<ICollection<NotificationDto>> GetNotificationsByUserIdAsync(long id);
        Task UpdateStatusToRead(long[] ids);
    }
}
