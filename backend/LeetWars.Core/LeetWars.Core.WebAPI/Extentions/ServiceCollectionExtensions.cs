﻿using LeetWars.Core.BLL.MappingProfiles;
using LeetWars.Core.BLL.Services;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.WebAPI.Validators;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using LeetWars.RabbitMQ;
using RabbitMQ.Client;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace LeetWars.Core.WebAPI.Extentions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterCustomServices(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddControllers()
                .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddScoped<IMessageSenderService, MessageSenderService>();
            services.AddTransient<IChallengeService, ChallengeService>();
            services.AddTransient<ITagService, TagService>();
            services.AddTransient<ILanguageService, LanguageService>();
            services.AddScoped<IUserService, UserService>();
        }

        public static void AddRabbitMqServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ProducerSettings>(configuration.GetSection("RabbitMQProducer"));
            services.AddSingleton(sp =>
            {
                var rabbitUri = new Uri(configuration["RabbitURI"]);
                var factory = new ConnectionFactory { Uri = rabbitUri };
                return factory.CreateConnection();
            });
            services.AddSingleton(sp => sp.GetRequiredService<IOptions<ProducerSettings>>().Value);
            services.AddSingleton<IProducerService, ProducerService>();
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
    }
}
