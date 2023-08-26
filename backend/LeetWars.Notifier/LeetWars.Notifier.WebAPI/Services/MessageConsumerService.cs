using LeetWars.RabbitMQ;
using RabbitMQ.Client.Events;
using System.Text;

namespace LeetWars.Notifier.WebAPI.Services
{
    public class MessageConsumerService : BackgroundService
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public MessageConsumerService(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using var scope = _serviceScopeFactory.CreateScope();
            var consumerService = scope.ServiceProvider.GetRequiredService<IConsumerService>();
            var handler = new EventHandler<BasicDeliverEventArgs>((model, args) =>
            {
                var body = args.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine(message); //impement some logic here using signalR
                consumerService.SetAcknowledge(args.DeliveryTag, true);
            });

            consumerService.Listen(handler);
            return Task.CompletedTask;
        }
    }
}
