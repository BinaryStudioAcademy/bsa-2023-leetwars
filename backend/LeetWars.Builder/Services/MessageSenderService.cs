using LeetWars.Builder.Interfaces;
using LeetWars.RabbitMQ;
using RabbitMQ.Client;

namespace LeetWars.Builder.Services;

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
<<<<<<< HEAD
}
=======
}
>>>>>>> feature/91-test-execution
