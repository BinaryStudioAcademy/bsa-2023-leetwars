using FluentValidation;
using LeetWars.Core.Common.DTO.Mail;
using LeetWars.Emailer.Interfaces;
using LeetWars.Emailer.Services;
using LeetWars.Emailer.Validators;
using LeetWars.RabbitMQ;
using Microsoft.Extensions.Options;
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

        public static void AddRabbitMqServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ConsumerSettings>(configuration.GetSection("RabbitMQConsumer"));
            services.AddSingleton(sp =>
            {
                var rabbitUri = new Uri(configuration["Rabbit"]);
                var factory = new ConnectionFactory { Uri = rabbitUri };
                return factory.CreateConnection();
            });
            services.AddSingleton(sp => sp.GetRequiredService<IOptions<ConsumerSettings>>().Value);
            services.AddSingleton<IConsumerService, ConsumerService>();
            services.AddHostedService<MessageConsumerService>();
        }
    }
}
