﻿using LeetWars.CodeAnalyzer.Interfaces;
using LeetWars.CodeAnalyzer.OpenAISettings;
using LeetWars.CodeAnalyzer.Services;
using LeetWars.CodeAnalyzer.WebAPI.MappingProfiles;
using OpenAI_API;
using System.Reflection;

namespace LeetWars.CodeAnalyzer.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterOpenAI(this IServiceCollection services)
        {
            services.AddSingleton(e => new OpenAIAPI(Environment.GetEnvironmentVariable("OPENAI_API_KEY")));

            services.AddScoped<IOpenAiSettings, OpenAiSettings>();
            services.AddScoped<ICompletionService, CompletionService>();
            services.AddScoped<IAnalyzeCodeService, AnalyzeCodeService>();
        }

        public static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetAssembly(typeof(ChallengeGeneratorProfile)));
        }
    }
}
