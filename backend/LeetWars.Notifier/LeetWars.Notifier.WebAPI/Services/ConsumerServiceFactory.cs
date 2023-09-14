using LeetWars.Notifier.WebAPI.Interfaces;
using LeetWars.Notifier.WebAPI.Models.Helpers;
using LeetWars.RabbitMQ;
using LeetWars.RabbitMQ.Services;

namespace LeetWars.Notifier.WebAPI.Services;

public class ConsumerServiceFactory : IConsumerServiceFactory
{
    private readonly IEnumerable<IConsumerService> _consumerServices;

    public ConsumerServiceFactory(IEnumerable<IConsumerService> consumerServices)
    {
        _consumerServices = consumerServices;
    }

    public IConsumerService GetInstance(string token)
    {
        return token switch
        {
            ConsumerNames.codeResultConsumer => this.GetService(typeof(NotifierCodeConsumerService)),
            ConsumerNames.broadcastConsumer => this.GetService(typeof(ConsumerService)),
            _ => throw new InvalidOperationException()
        };
    }

    public IConsumerService GetService(Type type)
    {
        return _consumerServices.FirstOrDefault(x => x.GetType() == type)!;
    }
}
