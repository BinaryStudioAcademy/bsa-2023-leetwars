using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace LeetWars.RabbitMQ.Services;
public class NotifierCodeConsumerService : IConsumerService
{
    private readonly IConnection _connection;
    private readonly IModel _channel;
    private readonly ConsumerSettings _settings;
    private bool disposedValue;

    public NotifierCodeConsumerService(IConnection connection, ConsumerSettings settings)
    {
        _connection = connection;
        _settings = settings;
        _channel = _connection.CreateModel();
    }

    public void Listen(EventHandler<BasicDeliverEventArgs> messageReceivedHandler)
    {
        ConsumerSetupHelperService.ListenSetup(messageReceivedHandler, _channel, _settings);
    }

    public void ListenAsync(AsyncEventHandler<BasicDeliverEventArgs> messageReceivedHandler)
    {
        ConsumerSetupHelperService.ListenAsyncSetup(messageReceivedHandler, _channel, _settings);
    }

    public void SetAcknowledge(ulong deliveryTag, bool processed)
    {
        ConsumerSetupHelperService.SetAcknowledgeSetup(deliveryTag, processed, _channel);
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
