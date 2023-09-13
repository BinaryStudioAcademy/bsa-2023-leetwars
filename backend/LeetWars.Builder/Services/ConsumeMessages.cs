﻿using LeetWars.Builder.Interfaces;
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

                if (request != null && Models.HelperModels.Languages.AvailableLanguages.Contains(request.Language))
                {
                    var result = await _codeRunManagerService.Run(request);

                    var settings = new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    };

                    var codeRunResultJson = JsonConvert.SerializeObject(result, settings);

                    var notifierMessage = new NotifierMessage() { HubName= "codeDisplayingHub", Message = codeRunResultJson };

                    var notifierJson = JsonConvert.SerializeObject(notifierMessage);
                    _producerService.Send(notifierJson, ExchangeType.Direct);
                }

                _consumerService.SetAcknowledge(args.DeliveryTag, true);
            });

            _consumerService.Listen(handler);
            return Task.CompletedTask;
        }
    }
}
