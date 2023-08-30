using LeetWars.RabbitMQ;
using RabbitMQ.Client.Events;
using System.Text;

namespace LeetWars.Builder.Services
{
    public class ConsumeMessages : BackgroundService
    {
        private readonly IConsumerService _consumerService;

        public ConsumeMessages(IConsumerService consumerService)
        {
            _consumerService = consumerService;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var handler = new EventHandler<BasicDeliverEventArgs>((model, args) =>
            {
                var body = args.Body.ToArray();
                var message = Encoding.UTF8.GetString(body).Replace('"', '\0');

                Console.WriteLine(message);

                _consumerService.SetAcknowledge(args.DeliveryTag, true);
            });

            _consumerService.Listen(handler);
            return Task.CompletedTask;
        }
    }
}
