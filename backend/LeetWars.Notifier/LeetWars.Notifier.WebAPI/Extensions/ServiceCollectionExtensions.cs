using LeetWars.Notifier.WebAPI.Services;
using LeetWars.RabbitMQ.Interfaces;
using LeetWars.RabbitMQ.Services;
using LeetWars.RabbitMQ.Settings;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;

namespace LeetWars.RabbitMQ.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRabbitMqServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ConsumerSettings>(configuration.GetSection("RabbitMQConsumer"));
            services.AddSingleton<IConsumerService, ConsumerService>();
            services.AddHostedService<MessageConsumerService>();
        }

        public static void AddCodeConsumerRabbitMqServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<RabbitMQCodeConsumerSettings>(configuration.GetSection("RabbitMQCodeConsumer"));
            services.AddSingleton<INotifierCodeConsumerService, NotifierCodeConsumerService>();
            services.AddHostedService<CodeMessageConsumerService>();
        }

        public static void RegisterRabbit(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(sp =>
            {
                var rabbitUri = new Uri(configuration["Rabbit"]);
                var factory = new ConnectionFactory { Uri = rabbitUri };
                return factory.CreateConnection();
            });

        }
    }
}
