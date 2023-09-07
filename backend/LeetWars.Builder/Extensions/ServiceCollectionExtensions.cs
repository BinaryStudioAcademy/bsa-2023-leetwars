using LeetWars.RabbitMQ;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;

namespace LeetWars.Builder.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterProduceMessagesServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ConsumerSettings>(configuration.GetSection("RabbitMQConsumer"));

            services.AddSingleton(con => new ConnectionFactory()
            {
                Uri = new Uri(configuration["Rabbit"])
            }
            .CreateConnection());
                
            services.AddSingleton(sp => sp.GetRequiredService<IOptions<ConsumerSettings>>().Value);
            services.AddSingleton<IConsumerService, ConsumerService>();
        }

        public static void AddRabbitMqServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ProducerSettings>(configuration.GetSection("RabbitMQProducer"));
<<<<<<< HEAD
=======

>>>>>>> feature/91-test-execution
            services.AddSingleton(sp =>
            {
                var rabbitUri = new Uri(configuration["Rabbit"]);
                var factory = new ConnectionFactory { Uri = rabbitUri };
                return factory.CreateConnection();
            });
<<<<<<< HEAD
            services.AddSingleton(sp => sp.GetRequiredService<IOptions<ProducerSettings>>().Value);
=======

            services.AddSingleton(sp => sp.GetRequiredService<IOptions<ProducerSettings>>().Value);

>>>>>>> feature/91-test-execution
            services.AddSingleton<IProducerService, ProducerService>();
        }
    }
}
