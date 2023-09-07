using LeetWars.Builder.Interfaces;
using LeetWars.Builder.RunnerDefaults;
using LeetWars.RabbitMQ;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace LeetWars.Builder.Services
{
    public class ConsumeMessages : BackgroundService
    {
        private readonly IConsumerService _consumerService;
        private readonly ISolutionRunnerService _solutionRunnerService;
        private readonly IProducerService _producerService;

        public ConsumeMessages(IConsumerService consumerService, ISolutionRunnerService solutionRunnerService, IProducerService producerService)
        {
            _consumerService = consumerService;
            _solutionRunnerService = solutionRunnerService;
            _producerService = producerService;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var handler = new EventHandler<BasicDeliverEventArgs>((model, args) =>
            {
                var body = args.Body.ToArray();
                var message = Encoding.UTF8.GetString(body).Replace('"', '\0');

                _solutionRunnerService.RunCodeInContainerAsync(DefaultRunnerImageNames.CSharpImage, "csharp-test-container");
                Console.WriteLine(message);

                _consumerService.SetAcknowledge(args.DeliveryTag, true);
                _producerService.Send("Hello Mario", ExchangeType.Direct);
            });

            _consumerService.Listen(handler);
            return Task.CompletedTask;
        }
    }
}
