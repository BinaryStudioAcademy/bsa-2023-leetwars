using RabbitMQ.Client;
using RabbitMQ.Client.Events;

public class ConsumerService : IConsumerService
{
    private readonly IConnection _connection;
    private readonly IModel _channel;
    private readonly ConsumerSettings _settings;

    public ConsumerService(IConnection connection, ConsumerSettings settings)
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

    public void Dispose()
    {
        _connection.Dispose();
        _channel.Dispose();
    }

    private void SetupChannel()
    {
        _channel.ExchangeDeclare(_settings.ExchangeName, _settings.ExchangeType);

        _channel.QueueDeclare(_settings.QueueName, true, false, false);

        _channel.QueueBind(_settings.QueueName, _settings.ExchangeName, _settings.RoutingKey);
    }
}