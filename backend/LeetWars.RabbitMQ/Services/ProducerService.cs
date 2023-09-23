using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

namespace LeetWars.RabbitMQ;
public class ProducerService : IProducerService
{
    private readonly IConnection _connection;
    private readonly ProducerSettings _producerSettings;
    private bool disposedValue;

    public ProducerService(IConnection connection, ProducerSettings producerSettings)
    {
        _connection = connection;
        _producerSettings = producerSettings;
    }

    public void Send(object obj, string? type)
    {
        var serializedObject = JsonSerializer.Serialize(obj);
        Send(serializedObject, type);
    }

    public void Send(string message, string? type)
    {
        using var channel = _connection.CreateModel();
        var properties = channel.CreateBasicProperties();
        properties.Persistent = true;

        if (!string.IsNullOrEmpty(type))
        {
            properties.Type = type;
        }

        channel.ExchangeDeclare(_producerSettings.ExchangeName, _producerSettings.ExchangeType);

        if (!string.IsNullOrEmpty(_producerSettings.QueueName))
        {
            channel.QueueDeclare(_producerSettings.QueueName, true, false, false);

            channel.QueueBind(
                _producerSettings.QueueName,
                _producerSettings.ExchangeName,
                _producerSettings.RoutingKey);
        }

        var body = Encoding.UTF8.GetBytes(message);

        channel.BasicPublish(
            new PublicationAddress(
                _producerSettings.ExchangeType,
                _producerSettings.ExchangeName,
                _producerSettings.RoutingKey),
            properties,
            body);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
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