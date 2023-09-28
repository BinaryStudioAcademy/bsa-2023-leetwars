using LeetWars.Core.Common.DTO.Notifications;

namespace LeetWars.Core.BLL.Interfaces
{
    public interface INotificationSenderService
    {
        void SendNotificationToRabbitMQ(NotificationDto newNotificationDto);
    }
}
