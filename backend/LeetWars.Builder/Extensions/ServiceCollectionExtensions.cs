using LeetWars.Builder.Services.Abstract;
using LeetWars.Builder.Services;
using LeetWars.RabbitMQ;
using RabbitMQ.Client;

namespace LeetWars.Builder.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterProduceMessagesServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(con => new ConnectionFactory()
            {
                Uri = new Uri(configuration["RabbitMQUri"])
            }
            .CreateConnection());

            services.Configure<ProducerSettings>(configuration.GetSection("ProducerSettings"))
                .AddSingleton<IProducerService, ProducerService>();

            services.AddScoped<IProduceMessages, ProduceMessages>();
        }

    }
}
