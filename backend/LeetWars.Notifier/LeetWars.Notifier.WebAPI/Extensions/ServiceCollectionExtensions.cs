using LeetWars.Notifier.WebAPI.Services;
using LeetWars.RabbitMQ;
using LeetWars.RabbitMQ.Interfaces;
using LeetWars.RabbitMQ.Services;
using LeetWars.RabbitMQ.Settings;
using RabbitMQ.Client;

namespace LeetWars.Notifier.WebAPI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterRabbit(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(sp =>
            {
                var rabbitUri = new Uri(configuration["Rabbit"]);
                var factory = new ConnectionFactory { Uri = rabbitUri };
                return factory.CreateConnection();
            });
            NotificationConsumer(services, configuration);
            BuilderNotificationConsumer(services, configuration);
        }

        private static void NotificationConsumer(IServiceCollection services, IConfiguration configuration)
        {
            var settings = configuration
                .GetSection("RabbitMQConsumer")
                .Get<ConsumerSettings>();

            services.AddSingleton<IConsumerService>(provider => new ConsumerService(
                provider.GetRequiredService<IConnection>(),
                settings));

            services.AddHostedService<NotificationConsumerService>();
        }        
        
        private static void BuilderNotificationConsumer(IServiceCollection services, IConfiguration configuration)
        {
            var settings = configuration
                .GetSection("RabbitMQCodeConsumer")
                .Get<RabbitMQCodeConsumerSettings>();

            services.AddSingleton<INotifierCodeConsumerService>(provider => new NotifierCodeConsumerService(
                provider.GetRequiredService<IConnection>(), settings));

            services.AddHostedService<CodeMessageConsumerService>();
        }
    }
}
