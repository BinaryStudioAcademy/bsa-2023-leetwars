using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        SetupChannel();

        var consumer = new EventingBasicConsumer(_channel);

        consumer.Received += messageReceivedHandler;

        if (_settings.SequentialFetch)
        {
            _channel.BasicQos(0, 1, false);
        }

        _channel.BasicConsume(_settings.QueueName, _settings.AutoAcknowledge, consumer);
    }

    public void ListenAsync(AsyncEventHandler<BasicDeliverEventArgs> messageReceivedHandler)
    {
        SetupChannel();

        var consumer = new AsyncEventingBasicConsumer(_channel);

        consumer.Received += messageReceivedHandler;

        if (_settings.SequentialFetch)
        {
            _channel.BasicQos(0, 1, false);
        }

        _channel.BasicConsume(_settings.QueueName, _settings.AutoAcknowledge, consumer);
    }

    public void SetAcknowledge(ulong deliveryTag, bool processed)
    {
        if (processed)
        {
            _channel.BasicAck(deliveryTag, false);
        }
        else
        {
            _channel.BasicNack(deliveryTag, false, true);
        }
    }

    private void SetupChannel()
    {
        _channel.ExchangeDeclare(_settings.ExchangeName, _settings.ExchangeType);

        _channel.QueueDeclare(_settings.QueueName, true, false, false);

        _channel.QueueBind(_settings.QueueName, _settings.ExchangeName, _settings.RoutingKey);
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
