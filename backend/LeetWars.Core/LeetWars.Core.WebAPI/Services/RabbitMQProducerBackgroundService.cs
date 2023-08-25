using LeetWars.RabbitMQ;
using RabbitMQ.Client;

namespace LeetWars.Core.WebAPI.Services
{
    public class RabbitMQProducerBackgroundService : BackgroundService
    {
        private readonly IConfiguration _configuration;
        private readonly IProducerService _producer;

        public RabbitMQProducerBackgroundService(IConfiguration configuration)
        {
            _configuration = configuration;
            _producer = new ProducerService(SetConnection(), SetProducerSettings());
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _producer.Send("Hello from Core to Builder!", ExchangeType.Direct);

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

        private ProducerSettings SetProducerSettings()
        {
            return new ProducerSettings()
            {
                ExchangeName = _configuration["ConsumerSettings:ExchangeName"],
                ExchangeType = _configuration["ConsumerSettings:ExchangeType"],
                QueueName = _configuration["ConsumerSettings:QueueName"],
                RoutingKey = _configuration["ConsumerSettings:RoutingKey"],
            };
        }
    }
}
