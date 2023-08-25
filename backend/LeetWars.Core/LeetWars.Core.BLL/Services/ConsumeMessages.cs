using LeetWars.RabbitMQ;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RabbitMQ.Client.Events;
using System.Text;

namespace LeetWars.Core.BLL.Services
{
    public class ConsumeMessages : BackgroundService
    {
        private readonly IServiceProvider _services;

        public ConsumeMessages(IServiceProvider services)
        {
            _services = services;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using var scope = _services.CreateScope();

            var consumerService = scope.ServiceProvider.GetRequiredService<IConsumerService>();

            var handler = new EventHandler<BasicDeliverEventArgs>((model, args) =>
            {
                var body = args.Body.ToArray();
                var message = Encoding.UTF8.GetString(body).Replace('"', '\0');

                //TODO: do something with message
                Console.WriteLine(message);

                consumerService.SetAcknowledge(args.DeliveryTag, true);
            });

            consumerService.Listen(handler);
            return Task.CompletedTask;
        }
    }
}
