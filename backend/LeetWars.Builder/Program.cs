using LeetWars.Builder.Services;
using LeetWars.Builder.Interfaces;
using LeetWars.Builder.RunnerDefaults;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ISolutionRunnerService, SolutionRunnerService>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/docker", () => new SolutionRunnerService().RunCodeAsync(DefaultRunnerImageNames.CSharpImage, "test-container"));

app.Run();
