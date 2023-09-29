using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Notifications;
using LeetWars.RabbitMQ;
using RabbitMQ.Client;

namespace LeetWars.Core.BLL.Services
{
    public class NotificationSenderService : INotificationSenderService
    {
        private readonly IProducerService _producerService;

        public NotificationSenderService(IProducerService producerService)
        {
            _producerService = producerService;
        }

        public void SendNotificationToRabbitMQ(NotificationDto newNotificationDto)
        {
            _producerService.Send(newNotificationDto, ExchangeType.Direct);
        }
    }
}
