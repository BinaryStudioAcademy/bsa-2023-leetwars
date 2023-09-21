using LeetWars.CodeAnalyzer.Extensions;
using LeetWars.CodeAnalyzer.Interfaces;
using LeetWars.CodeAnalyzer.Services;
using LeetWars.Core.Common.DTO.ChallengeRequest;
using LeetWars.Core.Common.DTO.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterOpenAI();
builder.Services.AddScoped<IChallengeGenerator, ChallengeGenerator>();

var app = builder.Build();





app.MapPost("/analyzecode", async (IAnalyzeCodeService analyzeCodeService,
                                          CodeRequestAnalysisDto requestDto) =>
{
    return await analyzeCodeService.RunCodeAnalysisAsync(requestDto);
});


app.MapPost("/generateChallenge", async (IChallengeGenerator challengeGenerator,
                                          ChallengeGenerateRequestDto challengeGenerateRequestDto) =>
{
    return await challengeGenerator.GenerateChallenge(challengeGenerateRequestDto);
});

app.Run();