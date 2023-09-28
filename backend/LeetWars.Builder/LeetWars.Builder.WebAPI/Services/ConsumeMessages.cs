using LeetWars.Builder.Interfaces;
using LeetWars.Builder.Models;
using LeetWars.Builder.RunnerDefaults.HelperModels;
using LeetWars.RabbitMQ;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using LeetWars.Builder.RunnerDefaults.HelperModels;
using LeetWars.Core.Common.DTO.CodeAnalysis;

namespace LeetWars.Builder.Services
{
    public class ConsumeMessages : BackgroundService
    {
        private readonly IConsumerService _consumerService;
        private readonly ICodeRunManagerService _codeRunManagerService;
        private readonly IProducerService _producerService;

        private readonly ICodeAnalysisService _codeAnalysisService;
        public ConsumeMessages(IConsumerService consumerService,ICodeAnalysisService codeAnalysisService, ICodeRunManagerService codeRunManagerService, IProducerService producerService)
        {
            _consumerService = consumerService;

            _codeRunManagerService = codeRunManagerService;

            _producerService = producerService;

            _codeAnalysisService = codeAnalysisService;
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
                    var codeRunResult = await _codeRunManagerService.RunAsync(request);

                    if (request.IsSubmitRequest)
                    {
                        var codeAnalysisResult =
                            await _codeAnalysisService.RunCodeAnalysisAsync(new CodeRequestAnalysisDto(request.Language, request.UserCode));
                        var result = new CodeSubmitResult(codeRunResult, codeAnalysisResult!);
                    
                        SendMessage(result);
                    }
                    else
                    {
                        SendMessage(codeRunResult);
                    }

                }
            });

            _consumerService.Listen(handler);

            return Task.CompletedTask;
        }

        private void SendMessage<T>(T data)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            var codeRunResultJson = JsonConvert.SerializeObject(data, settings);
            _producerService.Send(codeRunResultJson, ExchangeType.Direct);
        }
    }
}
