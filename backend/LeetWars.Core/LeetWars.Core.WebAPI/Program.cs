using LeetWars.Core.BLL.Services;
using LeetWars.Core.WebAPI.Extentions;
using LeetWars.Core.WebAPI.Middlewares;
using LeetWars.RabbitMQ;
using RabbitMQ.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", reloadOnChange: true, optional: true)
    .AddEnvironmentVariables()
    .Build();

builder.Services.AddControllers();
builder.Services.AddLeetWarsCoreContext(builder.Configuration);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.RegisterCustomServices();
builder.Services.AddAutoMapper();
builder.Services.AddSwaggerGen();
builder.Services.AddValidation();
builder.Services.AddFirebaseAuthentication(builder.Configuration);

builder.Services.AddCors();
builder.Services.AddHealthChecks();
builder.Services.AddRouting(options => options.LowercaseUrls = true);

builder.Services.AddSingleton(con => new ConnectionFactory()
{
    Uri = new Uri(builder.Configuration["RabbitURI"])
}
.CreateConnection());
builder.Services.Configure<ConsumerSettings>(builder.Configuration.GetSection("ConsumerSettings"))
    .AddScoped<IConsumerService, ConsumerService>();

builder.Services.AddHostedService<ConsumeMessages>();

builder.WebHost.UseUrls("http://*:5050");

var app = builder.Build();

app.UseLeetWarsCoreContext();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<GenericExceptionHandlerMiddleware>();

app.UseCors(opt => opt
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowAnyOrigin());

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.UseEndpoints(endpoinds =>
{
    endpoinds.MapHealthChecks("/health");
    endpoinds.MapControllers();
});

app.Run();
