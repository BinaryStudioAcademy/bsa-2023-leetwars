using LeetWars.Builder.Interfaces;
using LeetWars.Builder.Services;
using LeetWars.RabbitMQ;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;

namespace LeetWars.Builder.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterTestRunnerServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ISolutionRunnerService, SolutionRunnerService>();

            services.AddTransient<ICodeRunManagerService, CodeRunManagerService>();
            
            services.AddSingleton<ITarManagementService, TarManagementService>();
            
            services.AddSingleton<IXmlTestResultParserService, XmlTestResultParserService>();

        }

        public static void RegisterConsumeMessagesServices(this IServiceCollection services, IConfiguration configuration)
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

        public static void RegisterProduceMessagesServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ProducerSettings>(configuration.GetSection("RabbitMQProducer"));
            services.AddSingleton(sp => sp.GetRequiredService<IOptions<ProducerSettings>>().Value);
            services.AddSingleton<IProducerService, ProducerService>();
        }
    }
}
