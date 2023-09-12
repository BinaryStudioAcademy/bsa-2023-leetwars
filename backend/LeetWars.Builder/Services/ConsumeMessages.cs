using LeetWars.Builder.DTO;
using LeetWars.Builder.Interfaces;
using LeetWars.Builder.Models;
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
                var body = args.Body.ToArray();

                var message = Encoding.UTF8.GetString(body);

                var request = JsonConvert.DeserializeObject<CodeRunRequest>(message);

                if (request != null)
                {
                    var results = new CodeRunResults();

                    if (request.IsBuilt && !string.IsNullOrEmpty(request.Tests)){
                        results = await _codeRunManagerService.RunCodeAndTestsAsync(request);
                    }

                    string jsonObj = JsonConvert.SerializeObject(
                    results,
                    new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    });

                    var jsonWithConnectionID = JsonConvert.SerializeObject(new SignalRDto
                    {
                        ConnectionID = request.UserConnectionId,
                        JsonEntityToSend = jsonObj
                    });

                    _producerService.Send(jsonWithConnectionID, ExchangeType.Direct);
                }

                _consumerService.SetAcknowledge(args.DeliveryTag, true);

            });

            _consumerService.Listen(handler);

            return Task.CompletedTask;
        }
    }
}
