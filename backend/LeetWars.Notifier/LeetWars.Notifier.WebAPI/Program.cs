using LeetWars.Notifier.WebAPI.Hubs;
using LeetWars.RabbitMQ.Extensions;

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
builder.Services.AddRabbitMqServices(builder.Configuration);
builder.Services.AddCodeConsumerRabbitMqServices(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.WebHost.UseUrls("http://*:5070");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();

    app.UseSwagger();
    app.UseSwaggerUI();
}

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