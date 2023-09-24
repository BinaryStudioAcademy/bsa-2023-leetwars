using Azure.Storage.Blobs;
using FluentValidation.AspNetCore;
using LeetWars.Core.BLL.Helpers.BlobStorage;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.BLL.MappingProfiles;
using LeetWars.Core.BLL.Services;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.WebAPI.Logic;
using LeetWars.Core.WebAPI.Validators;
using LeetWars.RabbitMQ;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using RabbitMQ.Client;
using System.Reflection;

namespace LeetWars.Core.WebAPI.Extentions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterCustomServices(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddControllers()
                .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddTransient<IChallengeService, ChallengeService>();
            services.AddTransient<IChallengeLevelService, ChallengeLevelService>();
            services.AddTransient<ITagService, TagService>();
            services.AddTransient<ILanguageService, LanguageService>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<UserStorage>();
            services.AddTransient<IUserSetter>(s => s.GetService<UserStorage>()!);
            services.AddTransient<IUserGetter>(s => s.GetService<UserStorage>()!);
        }

        public static void AddRabbitMqServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(sp =>
            {
                var rabbitUri = new Uri(configuration["Rabbit"]);
                var factory = new ConnectionFactory { Uri = rabbitUri };
                return factory.CreateConnection();
            });

            RegisterEmailerProducer(services, configuration);
            RegisterNotificationProducerService(services, configuration);
            RegisterBuilderProducerService(services, configuration);
        }

        public static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetAssembly(typeof(SampleProfile)));
            services.AddAutoMapper(Assembly.GetAssembly(typeof(ChallengeProfile)));
            services.AddAutoMapper(Assembly.GetAssembly(typeof(TagProfile)));
            services.AddAutoMapper(Assembly.GetAssembly(typeof(LanguageProfile)));
            services.AddAutoMapper(Assembly.GetAssembly(typeof(UserProfile)));
        }

        public static void AddValidation(this IServiceCollection services)
        {
            services
                .AddControllers()
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<NewSampleDtoValidator>());
        }

        public static void AddLeetWarsCoreContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionsString = configuration.GetConnectionString("LeetWarsCoreDBConnection");
            services.AddDbContext<LeetWarsCoreContext>(options =>
                options.UseSqlServer(
                    connectionsString,
                    opt => opt.MigrationsAssembly(typeof(LeetWarsCoreContext).Assembly.GetName().Name)));
        }

        public static void AddFirebaseAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var firebaseSettings = configuration.GetSection("Firebase");
            var tokenIssuerBaseUrl = firebaseSettings["TokenIssuerBaseUrl"] ?? "";
            var appName = firebaseSettings["AppName"] ?? "";
            var tokenIssuerUrl = $"{tokenIssuerBaseUrl}/{appName}";

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Authority = tokenIssuerUrl;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidIssuer = tokenIssuerUrl,
                        ValidateAudience = true,
                        ValidAudience = appName,
                        ValidateLifetime = true
                    };
                });
        }

        public static IServiceCollection AddAzureBlobServices(
            this IServiceCollection services, IConfiguration configuration)
        {
            var blobUrl = configuration["BLOB_URL"];
            var blobContainerName = configuration["BlobContainerName"];
            var blobAccess = configuration["BlobAccess"];

            var settings = new BlobStorageSettings(blobUrl, blobContainerName, blobAccess);
            var blobContainerClient = new BlobContainerClient(settings.BlobUrl, settings.BlobContainerName);

            services.AddSingleton(_ => settings);

            services.AddSingleton(_ => blobContainerClient);

            services.AddScoped<IBlobService, BlobService>();

            return services;
        }

        private static void RegisterNotificationProducerService(IServiceCollection services, IConfiguration configuration)
        {
            var settings = configuration
                .GetSection("RabbitMQProducers:Emailer")
                .Get<ProducerSettings>();

            services.AddSingleton<IEmailSenderService>(provider =>
                new EmailSenderService(new ProducerService(
                    provider.GetRequiredService<IConnection>(),
                    settings)));
        }

        private static void RegisterBuilderProducerService(IServiceCollection services, IConfiguration configuration)
        {
            var settings = configuration
                .GetSection("RabbitMQProducers:Builder")
                .Get<ProducerSettings>();

            services.AddSingleton<IBuilderSenderService>(provider =>
                new BuilderSenderService(new ProducerService(
                    provider.GetRequiredService<IConnection>(),
                    settings)));
        }

        private static void RegisterEmailerProducer(IServiceCollection services, IConfiguration configuration)
        {
            var settings = configuration
                .GetSection("RabbitMQProducers:Notifier")
                .Get<ProducerSettings>();

            services.AddSingleton<INotificationSenderService>(provider =>
                new NotificationSenderService(new ProducerService(
                    provider.GetRequiredService<IConnection>(),
                    settings)));
        }
    }
}
