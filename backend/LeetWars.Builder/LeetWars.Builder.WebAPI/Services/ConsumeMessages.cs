using LeetWars.Builder.Interfaces;
using LeetWars.Builder.Models;
using LeetWars.Builder.RunnerDefaults.HelperModels;
using LeetWars.RabbitMQ;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
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
                _consumerService.SetAcknowledge(args.DeliveryTag, true);

                var body = args.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);

                var request = JsonConvert.DeserializeObject<CodeRunRequest>(message);

                if (request != null && Languages.AvailableLanguages.Contains(request.Language))
                {
                    var result = await _codeRunManagerService.RunAsync(request);

                    var settings = new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    };

                    var codeRunResultJson = JsonConvert.SerializeObject(result, settings);
                    _producerService.Send(codeRunResultJson, ExchangeType.Direct);

                }
            });

            _consumerService.Listen(handler);

            return Task.CompletedTask;
        }
    }
}
