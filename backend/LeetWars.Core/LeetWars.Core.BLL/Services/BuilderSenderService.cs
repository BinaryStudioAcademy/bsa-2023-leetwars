using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.CodeRunRequest;
using LeetWars.RabbitMQ;
using RabbitMQ.Client;

namespace LeetWars.Core.BLL.Services
{
    public class BuilderSenderService : IBuilderSenderService
    {
        private readonly IProducerService _producerService;

        public BuilderSenderService(IProducerService producerService)
        {
            _producerService = producerService;
        }

        public void SendNotificationToRabbitMQ(CodeRunRequestDto codeRunRequestDto)
        {
            _producerService.Send(codeRunRequestDto, ExchangeType.Direct);
        }
    }
}
