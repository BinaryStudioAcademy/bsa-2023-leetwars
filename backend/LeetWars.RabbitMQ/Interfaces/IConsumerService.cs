using RabbitMQ.Client.Events;

public interface IConsumerService : IDisposable
{
    void Listen(EventHandler<BasicDeliverEventArgs> messageReceivedHandler);
    void ListenAsync(AsyncEventHandler<BasicDeliverEventArgs> messageReceivedHandler);
    void SetAcknowledge(ulong deliveryTag, bool processed);
}