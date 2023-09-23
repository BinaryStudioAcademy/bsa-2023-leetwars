using FluentValidation;
using LeetWars.Core.Common.DTO.Mail;
using LeetWars.Emailer.Interfaces;
using LeetWars.Emailer.Services;
using LeetWars.Emailer.Validators;
using LeetWars.RabbitMQ;
using LeetWars.RabbitMQ.Settings;
using RabbitMQ.Client;

namespace LeetWars.Emailer.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IMailService, MailService>();
            services.AddScoped<IValidator<MailDto>, MailDtoValidator>();
        }

        public static void RegisterConsumerServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(cf => new ConnectionFactory()
            {
                Uri = new Uri(configuration["Rabbit"])
            }
            .CreateConnection());

            RegisterEmailerConsumer(services, configuration);
        }

        private static void RegisterEmailerConsumer(IServiceCollection services, IConfiguration configuration)
        {
            var settings = configuration
                .GetSection("RabbitMQConsumer")
                .Get<ConsumerSettings>();

            services.AddSingleton<IConsumerService>(provider => new ConsumerService(
                provider.GetRequiredService<IConnection>(),
                settings));

            services.AddHostedService<MessageConsumerService>();
        }
    }
}
