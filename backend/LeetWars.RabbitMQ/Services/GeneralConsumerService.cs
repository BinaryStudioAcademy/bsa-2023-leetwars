using LeetWars.RabbitMQ.Interfaces;
using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using LeetWars.RabbitMQ.Settings;
using Microsoft.Extensions.Options;

namespace LeetWars.RabbitMQ.Services;
public class GeneralConsumerService : IGeneralConsumerService
{
    protected readonly IConnection _connection;
    protected readonly IModel _channel;
    protected readonly GeneralConsumerSettings _settings;
    protected bool disposedValue;

    public GeneralConsumerService(IConnection connection, GeneralConsumerSettings settings)
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
