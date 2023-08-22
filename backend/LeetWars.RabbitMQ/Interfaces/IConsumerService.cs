using RabbitMQ.Client.Events;

namespace LeetWars.RabbitMQ;
public interface IConsumerService : IDisposable
{
    void Listen(EventHandler<BasicDeliverEventArgs> messageReceivedHandler);
    void ListenAsync(AsyncEventHandler<BasicDeliverEventArgs> messageReceivedHandler);
    void SetAcknowledge(ulong deliveryTag, bool processed);
}