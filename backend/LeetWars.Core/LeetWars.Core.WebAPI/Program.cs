using Hangfire;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.Extensions;
using LeetWars.Core.Common.Filters;
using LeetWars.Core.WebAPI.Extentions;
using LeetWars.Core.WebAPI.Middlewares;
using Newtonsoft.Json.Converters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", reloadOnChange: true, optional: true)
    .AddEnvironmentVariables()
    .Build();

builder.Services.AddControllers(options => options.Filters.Add<CustomExceptionFilterAttribute>())
    .AddNewtonsoftJson(x => x.SerializerSettings.Converters.Add(new StringEnumConverter()));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddLeetWarsCoreContext(builder.Configuration);
builder.Services.AddRabbitMqServices(builder.Configuration);
builder.Services.RegisterCustomServices(builder.Configuration);
builder.Services.AddAzureBlobServices(builder.Configuration);
builder.Services.AddAutoMapper();
builder.Services.AddSwaggerGen();
builder.Services.AddFirebaseAuthentication(builder.Configuration);
builder.Services.RegisterHengfire(builder.Configuration);

builder.Services.AddCors();
builder.Services.AddHealthChecks();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.WebHost.UseUrls("http://*:5050");

builder.Services.AddHangfireServer();

var app = builder.Build();

app.UseLeetWarsCoreContext();

app.UseHangfireDashboard();

RecurringJob.AddOrUpdate<IChallengeService>("SetWeeklyChallengesAsync",
    service => service.SetWeeklyChallengesAsync(),
    Cron.Weekly());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureCustomExceptionMiddleware();

app.UseCors(opt => opt
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowAnyOrigin());

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.UseMiddleware<UserSaverMiddleware>();

app.UseEndpoints(endpoinds =>
{
    endpoinds.MapHealthChecks("/health");
    endpoinds.MapControllers();
});

app.Run();
