using LeetWars.RabbitMQ;

namespace LeetWars.Notifier.WebAPI.Interfaces;

public interface IConsumerServiceFactory
{
    IConsumerService GetInstance(string token);
}
