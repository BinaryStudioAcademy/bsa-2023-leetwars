using LeetWars.CodeAnalyzer.Extensions;
using LeetWars.CodeAnalyzer.Interfaces;
using LeetWars.CodeAnalyzer.Services;
using Newtonsoft.Json.Converters;


var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", reloadOnChange: true, optional: true)
    .AddEnvironmentVariables()
    .Build();

builder.Services.AddAutoMapper();
builder.Services.AddControllers()
    .AddNewtonsoftJson(x => x.SerializerSettings.Converters.Add(new StringEnumConverter()));


builder.Services.RegisterOpenAI();
builder.Services.AddScoped<IChallengeGenerator, ChallengeGenerator>();

builder.Services.AddCors();
builder.WebHost.UseUrls("http://*:5100");
builder.Services.AddSwaggerGen();
builder.Services.AddRouting(options => options.LowercaseUrls = true);


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

app.Run();