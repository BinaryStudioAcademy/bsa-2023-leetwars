﻿using LeetWars.RabbitMQ;
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

            services.AddSingleton(sp =>
            {
                var rabbitUri = new Uri(configuration["Rabbit"]);
                var factory = new ConnectionFactory { Uri = rabbitUri };
                return factory.CreateConnection();
            });

            services.AddSingleton(sp => sp.GetRequiredService<IOptions<ProducerSettings>>().Value);

            services.AddSingleton<IProducerService, ProducerService>();
        }
    }
}
