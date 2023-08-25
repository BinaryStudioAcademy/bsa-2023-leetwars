using LeetWars.RabbitMQ;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace LeetWars.Builder.Services
{
    public class RabbitMQConsumerBackgroundService : BackgroundService
    {
        private readonly IConfiguration _configuration;
        private readonly IConsumerService _consumer;

        public RabbitMQConsumerBackgroundService(IConfiguration configuration)
        {
            _configuration = configuration;
            _consumer = new ConsumerService(SetConnection(), SetConsumerSettings());
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {

            var handler = new EventHandler<BasicDeliverEventArgs>((model, args) =>
            {
                var body = args.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine(message);
                //TODO: add logic with hubs
            });

            _consumer.Listen(handler);
            return Task.CompletedTask;
        }

        private IConnection SetConnection()
        {
            var factory = new ConnectionFactory()
            {
                Uri = new Uri(_configuration["RabbitURI"])
            };

            return factory.CreateConnection();
        }

        private ConsumerSettings SetConsumerSettings()
        {
            return new ConsumerSettings()
            {
                ExchangeName = _configuration["ConsumerSettings:ExchangeName"],
                ExchangeType = _configuration["ConsumerSettings:ExchangeType"],
                QueueName = _configuration["ConsumerSettings:QueueName"],
                RoutingKey = _configuration["ConsumerSettings:RoutingKey"],
            };
        }
    }
}
