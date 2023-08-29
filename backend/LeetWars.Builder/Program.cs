using LeetWars.Builder.Services;
using LeetWars.Builder.Interfaces;
using LeetWars.Builder.RunnerDefaults;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ISolutionRunnerService, SolutionRunnerService>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//Test
app.MapGet("/docker/csharp", () => new SolutionRunnerService().RunCodeInContainerAsync(DefaultRunnerImageNames.CSharpImage, "csharp-test-container"));

app.MapGet("/docker/js", () => new SolutionRunnerService().RunCodeInContainerAsync(DefaultRunnerImageNames.JSImage, "js-test-container"));

app.Run();
