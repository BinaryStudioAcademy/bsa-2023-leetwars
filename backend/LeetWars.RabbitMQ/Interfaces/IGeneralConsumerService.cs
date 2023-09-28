using RabbitMQ.Client.Events;

namespace LeetWars.RabbitMQ.Interfaces;
public interface IGeneralConsumerService : IDisposable
{
    void Listen(EventHandler<BasicDeliverEventArgs> messageReceivedHandler);

    void SetAcknowledge(ulong deliveryTag, bool processed);
}
