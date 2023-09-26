using LeetWars.Builder.Interfaces;
using LeetWars.Builder.Services;
using LeetWars.RabbitMQ;
using LeetWars.RabbitMQ.Settings;
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
            services.AddSingleton(con => new ConnectionFactory()
            {
                Uri = new Uri(configuration["Rabbit"])
            }
            .CreateConnection());

            RegisterBuilderProducerService(services, configuration);
            RegisterBuilderConsumer(services, configuration);
        }

        private static void RegisterBuilderConsumer(IServiceCollection services, IConfiguration configuration)
        {
            var settings = configuration
                .GetSection("RabbitMQConsumer")
                .Get<ConsumerSettings>();

            services.AddSingleton<IConsumerService>(provider => new ConsumerService(
                provider.GetRequiredService<IConnection>(),
                settings));

            services.AddHostedService<ConsumeMessages>();
        }

        private static void RegisterBuilderProducerService(IServiceCollection services, IConfiguration configuration)
        {
            var settings = configuration
                .GetSection("RabbitMQProducer")
                .Get<ProducerSettings>();

            services.AddSingleton<IProducerService>(provider =>
                    new ProducerService(
                    provider.GetRequiredService<IConnection>(),
                    settings));
        }
    }
}
