using LeetWars.Builder.Interfaces;
using LeetWars.Builder.Models;
using LeetWars.RabbitMQ;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
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

                if (request != null && Models.HelperModels.Languages.AvailableLanguages.Contains(request.Language))
                {
                    var buildResult = await _codeRunManagerService.Run(request);

                    if (buildResult.BuildResults != null && buildResult.BuildResults.IsSuccess)
                    {
                        await _codeRunManagerService.RunCodeAndTestsAsync(request, buildResult);
                    }

                    var settings = new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    };

                    var codeRunResultJson = JsonConvert.SerializeObject(buildResult, settings);

                    var notifierMessage = new NotifierMessage() { HubName = "codeDisplayingHub", Message = codeRunResultJson };

                    var notifierJson = JsonConvert.SerializeObject(notifierMessage);
                    _producerService.Send(codeRunResultJson, ExchangeType.Direct);
                }

                _consumerService.SetAcknowledge(args.DeliveryTag, true);
            });

            _consumerService.Listen(handler);

            return Task.CompletedTask;
        }
    }
}
