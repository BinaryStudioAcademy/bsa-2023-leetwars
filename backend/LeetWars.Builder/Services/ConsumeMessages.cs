using LeetWars.Builder.Interfaces;
using LeetWars.RabbitMQ;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using LeetWars.Builder.Models;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace LeetWars.Builder.Services
{
    public class ConsumeMessages : BackgroundService
    {
        private readonly IConsumerService _consumerService;
        private readonly ICodeRunManagerService _codeRunManagerService;
        private readonly IProducerService _producerService;
        public ConsumeMessages(IConsumerService consumerService, ICodeRunManagerService codeRunManagerService, IProducerService producerService)
        {
            _consumerService = consumerService;
            _codeRunManagerService = codeRunManagerService;
            _producerService = producerService;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var handler = new EventHandler<BasicDeliverEventArgs>(async (model, args) =>
            {
                var body = args.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);

                var request = JsonConvert.DeserializeObject<CodeRunRequest>(message);

                var languages = new List<string> { "C#", "javascript" };

                if(languages.Contains(request.Language))
                {
                    var result = await _codeRunManagerService.Run(request);

                    var settings = new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    };

                    var jsonString = JsonConvert.SerializeObject(result, settings);

                    _producerService.Send("Hello Mario", ExchangeType.Direct);
                }

                _consumerService.SetAcknowledge(args.DeliveryTag, true);
            });

            _consumerService.Listen(handler);
            return Task.CompletedTask;
        }
    }
}
