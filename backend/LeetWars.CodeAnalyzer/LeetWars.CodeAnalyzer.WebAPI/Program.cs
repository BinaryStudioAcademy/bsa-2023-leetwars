using LeetWars.CodeAnalyzer.Extensions;
using LeetWars.CodeAnalyzer.Interfaces;
using LeetWars.Core.Common.DTO.CodeAnalysis;
using LeetWars.Core.Common.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterOpenAI();

var app = builder.Build();

app.ConfigureCustomExceptionMiddleware();

app.MapPost("/analyzecode", async (IAnalyzeCodeService analyzeCodeService, 
                                          CodeRequestAnalysisDto requestDto) =>
{
    return await analyzeCodeService.RunCodeAnalysisAsync(requestDto);
});

app.Run();