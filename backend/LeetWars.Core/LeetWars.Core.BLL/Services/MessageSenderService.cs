using LeetWars.Core.BLL.Interfaces;
using LeetWars.RabbitMQ;
using RabbitMQ.Client;

namespace LeetWars.Core.BLL.Services
{
    public class MessageSenderService : IMessageSenderService
    {
        private readonly IProducerService _producerService;

        public MessageSenderService(IProducerService producerService)
        {
            _producerService = producerService; 
        }

        public void SendMessageToRabbitMQ(object obj)
        {
            _producerService.Send(obj, ExchangeType.Direct);
        }
    }
}
