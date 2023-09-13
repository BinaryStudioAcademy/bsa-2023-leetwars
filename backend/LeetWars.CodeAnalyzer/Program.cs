using LeetWars.CodeAnalyzer.Extensions;
using LeetWars.CodeAnalyzer.Interfaces;
using LeetWars.Core.Common.DTO.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterOpenAI(builder.Configuration);

var app = builder.Build();

app.MapPost("/analyzecode", async (IAnalyzeCodeService analyzeCodeService, 
                                          CodeRequestAnalysisDto requestDto) =>
{
    return await analyzeCodeService.RunCodeAnalysisAsync(requestDto);
});

app.Run();