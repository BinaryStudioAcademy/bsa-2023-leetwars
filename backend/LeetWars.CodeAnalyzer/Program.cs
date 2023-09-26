using LeetWars.CodeAnalyzer.Extensions;
using LeetWars.CodeAnalyzer.Interfaces;
using LeetWars.CodeAnalyzer.Services;
using LeetWars.Core.Common.DTO.ChallengeGenerate;
using LeetWars.Core.Common.DTO.ChallengeRequest;
using LeetWars.Core.Common.DTO.CodeAnalysis;
using LeetWars.Core.WebAPI.Filters;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", reloadOnChange: true, optional: true)
    .AddEnvironmentVariables()
    .Build();

builder.Services.AddControllers(options => options.Filters.Add<CustomExceptionFilterAttribute>())
    .AddNewtonsoftJson(x => x.SerializerSettings.Converters.Add(new StringEnumConverter()));


builder.Services.RegisterOpenAI();
builder.Services.AddScoped<IChallengeGenerator, ChallengeGenerator>();


//builder.Services.Configure<Microsoft.AspNetCore.Mvc.JsonOptions>(options =>
//{
//    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
//});
builder.Services.AddCors();
builder.Services.AddSwaggerGen();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.WebHost.UseUrls("http://*:5100");





var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseCors(opt => opt
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowAnyOrigin());

app.UseHttpsRedirection();

app.UseRouting();

app.UseEndpoints(endpoinds =>
{
    endpoinds.MapControllers();
});






//app.MapPost("/analyzecode", async (IAnalyzeCodeService analyzeCodeService,
//                                          CodeRequestAnalysisDto requestDto) =>
//{
//    return await analyzeCodeService.RunCodeAnalysisAsync(requestDto);
//});


//app.MapPost("/generateChallenge", async (IChallengeGenerator challengeGenerator,
//                                          ChallengeGenerateRequestDto challengeGenerateRequestDto) =>
//{
//    var response = await challengeGenerator.GenerateChallenge(challengeGenerateRequestDto);
//    return Results.Ok(response);

//}).Produces<ChallengeGenerateResponseDto>();



app.Run();