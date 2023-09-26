using LeetWars.Core.Common.DTO.Mail;
using LeetWars.Emailer.Interfaces;
using LeetWars.RabbitMQ;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;

namespace LeetWars.Emailer.Services
{
    public class MessageConsumerService : BackgroundService
    {
        private readonly IConsumerService _consumerService;
        private readonly IServiceProvider _serviceProvider;

        public MessageConsumerService(IConsumerService consumerService, IServiceProvider serviceProvider)
        {
            _consumerService = consumerService;
            _serviceProvider = serviceProvider;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var handler = new EventHandler<BasicDeliverEventArgs>((model, args) =>
            {
                var body = args.Body.ToArray();
                var jsonMail = Encoding.UTF8.GetString(body);
                var mailDto = JsonSerializer.Deserialize<MailDto>(jsonMail)!;
                var mailService = _serviceProvider.CreateScope().ServiceProvider.GetRequiredService<IMailService>();
                mailService.SendWithValidationCheckAsync(mailDto);
                _consumerService.SetAcknowledge(args.DeliveryTag, true);
            });

            _consumerService.Listen(handler);
            return Task.CompletedTask;
        }
    }
}
