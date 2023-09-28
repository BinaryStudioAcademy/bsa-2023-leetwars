using LeetWars.Builder.Extensions;
using LeetWars.Builder.Interfaces;
using LeetWars.Builder.Services;
using LeetWars.Core.Common.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.RegisterConsumeMessagesServices(builder.Configuration);
builder.Services.AddSingleton<ISolutionRunnerService, SolutionRunnerService>();
builder.Services.AddTransient<ICodeRunManagerService, CodeRunManagerService>();
builder.Services.AddHttpClient<ICodeAnalysisService, CodeAnalysisHttpClient>(((client) =>
{
    client.BaseAddress = new Uri(builder.Configuration["CodeAnalysis"]);
}));

builder.Services.RegisterTestRunnerServices(builder.Configuration);

var app = builder.Build();

app.ConfigureCustomExceptionMiddleware();

app.MapGet("/", () => "Hello, world!");

app.Run();
