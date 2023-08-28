using LeetWars.Notifier.WebAPI.Services;
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
                var rabbitHostName = "localhost";
                if (Environment.GetEnvironmentVariable("DOCKER_ENV") == "true")
                {
                    rabbitHostName = "rabbitmq";
                }
                var rabbitUri = new Uri($"amqp://guest:guest@{rabbitHostName}:5672");
                var factory = new ConnectionFactory { Uri = rabbitUri };
                return factory.CreateConnection();
            });
            services.AddSingleton(sp => sp.GetRequiredService<IOptions<ConsumerSettings>>().Value);
            services.AddSingleton<IConsumerService, ConsumerService>();
            services.AddHostedService<MessageConsumerService>();
        }
    }
}
