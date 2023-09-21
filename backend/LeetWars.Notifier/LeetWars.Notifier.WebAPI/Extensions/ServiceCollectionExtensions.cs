using LeetWars.Notifier.WebAPI.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;

namespace LeetWars.RabbitMQ.Extensions
{
    public static class ServiceCollectionExtensions
    {
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
            services.AddHostedService<NotificationConsumerService>();
        }
    }
}
