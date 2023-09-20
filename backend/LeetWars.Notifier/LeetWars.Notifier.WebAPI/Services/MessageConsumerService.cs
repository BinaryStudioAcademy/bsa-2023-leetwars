using RabbitMQ.Client.Events;
using System.Text;
using Newtonsoft.Json;
using LeetWars.Notifier.WebAPI.Models;
using LeetWars.RabbitMQ;

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
                _consumerService.SetAcknowledge(args.DeliveryTag, true);

                var body = args.Body.ToArray();

                var message = Encoding.UTF8.GetString(body);
                var request = JsonConvert.DeserializeObject<CodeRunResults>(message);
            });

            _consumerService.Listen(handler);

            return Task.CompletedTask;
        }
    }
}
