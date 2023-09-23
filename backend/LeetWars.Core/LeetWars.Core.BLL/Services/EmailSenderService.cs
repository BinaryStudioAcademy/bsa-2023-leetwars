using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Mail;
using LeetWars.RabbitMQ;
using RabbitMQ.Client;

namespace LeetWars.Core.BLL.Services
{
    public class EmailSenderService : IEmailSenderService
    {
        private readonly IProducerService _producerService;

        public EmailSenderService(IProducerService producerService)
        {
            _producerService = producerService;
        }

        public void SendEmailMessageToRabbitMQ(MailDto mailDto)
        {
            _producerService.Send(mailDto, ExchangeType.Direct);
        }
    }
}
