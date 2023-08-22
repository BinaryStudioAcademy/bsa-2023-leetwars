using RabbitMQ.Client;
using System.Text;
using System.Text.Json;


namespace LeetWars.Core.WebAPI.RabbitMQ
{
    public class RabbitMqService : IRabbitMqService
    {
        private readonly IConfiguration _configuration;

        public RabbitMqService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void SendMessage(object obj)
        {
            var message = JsonSerializer.Serialize(obj);
            SendMessage(message);
        }

        public void SendMessage(string message)
        {
            var factory = new ConnectionFactory()
            {
                HostName = _configuration["RabbitMQ:HostName"],
            };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            channel.QueueDeclare(queue: _configuration["RabbitMQ:QueueName"],
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            var body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(exchange: "",
                routingKey: _configuration["RabbitMQ:QueueName"],
                basicProperties: null,
                body: body);

        }

    }
}
