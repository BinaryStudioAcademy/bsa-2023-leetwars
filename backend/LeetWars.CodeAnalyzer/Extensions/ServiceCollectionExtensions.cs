using LeetWars.CodeAnalyzer.Interfaces;
using LeetWars.CodeAnalyzer.OpenAISettings;
using LeetWars.CodeAnalyzer.Services;
using Microsoft.AspNetCore.Connections;
using Microsoft.Extensions.Options;
using OpenAI_API;

namespace LeetWars.CodeAnalyzer.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterOpenAI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(e =>
            {
                var api = OpenAIAPI.ForAzure(
                    configuration["ResouceName"], 
                    configuration["DeploymentId"], 
                    Environment.GetEnvironmentVariable("OPENAI_API_KEY"));
                api.ApiVersion = OpenAiCompletionSettings.ApiVersion;

                return api;
            });

            services.AddScoped<IOpenAiSettings, OpenAiSettings>();
            services.AddScoped<ICompletionService, CompletionService>();
        }
    }
}
