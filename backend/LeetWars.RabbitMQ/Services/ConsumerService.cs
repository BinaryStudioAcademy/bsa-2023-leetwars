using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace LeetWars.RabbitMQ;
public class ConsumerService : IConsumerService
{
    private readonly IConnection _connection;
    private readonly IModel _channel;
    private readonly ConsumerSettings _settings;
    private bool disposedValue;

    public ConsumerService(IConnection connection, ConsumerSettings settings)
    {
        _connection = connection;
        _settings = settings;
        _channel = _connection.CreateModel();
    }

    public void Listen(EventHandler<BasicDeliverEventArgs> messageReceivedHandler)
    {
        ConsumerSetupHelper.ListenSetup(messageReceivedHandler, _channel, _settings);
    }

    public void ListenAsync(AsyncEventHandler<BasicDeliverEventArgs> messageReceivedHandler)
    {
        ConsumerSetupHelper.ListenAsyncSetup(messageReceivedHandler, _channel, _settings);
    }

    public void SetAcknowledge(ulong deliveryTag, bool processed)
    {
        ConsumerSetupHelper.SetAcknowledgeSetup(deliveryTag, processed, _channel);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                _channel.Dispose();
                _connection.Dispose();
            }

            disposedValue = true;
        }
    }

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}