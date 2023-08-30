using LeetWars.RabbitMQ;
using RabbitMQ.Client.Events;
using System.Text;

namespace LeetWars.Notifier.WebAPI.Services
{
    public class MessageConsumerService : BackgroundService
    {
        private readonly IConsumerService _consumerService;

        public MessageConsumerService(IConsumerService consumerService)
        {
            _consumerService = consumerService; 
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var handler = new EventHandler<BasicDeliverEventArgs>((model, args) =>
            {
                var body = args.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine(message); //impement some logic here using signalR
                _consumerService.SetAcknowledge(args.DeliveryTag, false);
            });

            _consumerService.Listen(handler);
            return Task.CompletedTask;
        }
    }
}
