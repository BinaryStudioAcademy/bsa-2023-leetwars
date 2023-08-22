using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Diagnostics;
using System.Text;

namespace LeetWars.Core.WebAPI
{
    public class ListenerService : BackgroundService
    {
        private readonly IConfiguration _configuration;
        private IConnection _connection;
        private IModel _channel;

        public ListenerService(IConfiguration configuration)
        {
            _configuration = configuration;

            var factory = new ConnectionFactory { HostName = _configuration["RabbitMQ:HostName"] };
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
            _channel.QueueDeclare(queue: _configuration["RabbitMQ:QueueName"], durable: false, exclusive: false, autoDelete: false, arguments: null);

        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            stoppingToken.ThrowIfCancellationRequested();
            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += async (ch, ea) =>
            {
                var content = Encoding.UTF8.GetString(ea.Body.ToArray());
                Debug.WriteLine($"Message received {content}");
                _channel.BasicAck(ea.DeliveryTag, false);
            };
            _channel.BasicConsume(_configuration["RabbitMQ:QueueName"], false, consumer);
            return Task.CompletedTask;
        }

        public override void Dispose()
        {
            _channel.Dispose();
            _connection.Dispose();
            base.Dispose();
        }
    }
}
