using LeetWars.RabbitMQ;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;

namespace LeetWars.Builder.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterProduceMessagesServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(con => new ConnectionFactory()
            {
                Uri = new Uri(configuration["RabbitUri"])
            }
            .CreateConnection());

            services.Configure<ConsumerSettings>(configuration.GetSection("RabbitMQConsumer"))
                .AddSingleton<IConsumerService, ConsumerService>();

            services.AddSingleton(sp => sp.GetRequiredService<IOptions<ConsumerSettings>>().Value);
        }

    }
}
