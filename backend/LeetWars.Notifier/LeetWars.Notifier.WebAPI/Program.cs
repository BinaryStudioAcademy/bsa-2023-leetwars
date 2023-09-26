using LeetWars.Core.Common.Extensions;
using LeetWars.Notifier.WebAPI.Extensions;
using LeetWars.Notifier.WebAPI.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", reloadOnChange: true, optional: true)
    .AddEnvironmentVariables()
    .Build();

builder.Services.AddControllers();

builder.Services.AddSignalR();
builder.Services.RegisterRabbit(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.WebHost.UseUrls("http://*:5070");

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();

    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureCustomExceptionMiddleware();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapHub<CodeDisplayingHub>("/codeDisplayingHub");
    endpoints.MapHub<NotificationsHub>("/notificationHub");
    endpoints.MapHealthChecks("/health");
});

app.UseHttpsRedirection();

app.MapControllers();

app.Run();