using LeetWars.Builder.Services;
using LeetWars.Builder.Services.Abstract;
using LeetWars.RabbitMQ;
using RabbitMQ.Client;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton(con => new ConnectionFactory()
{
    Uri = new Uri(builder.Configuration["RabbitURI"])
}
.CreateConnection());
builder.Services.Configure<ProducerSettings>(builder.Configuration.GetSection("ProducerSettings"))
    .AddTransient<IProducerService, ProducerService>();

builder.Services.AddScoped<IProduceMessages, ProduceMessages>();

var app = builder.Build();

//TODO: Replace with real implementation
app.MapGet("/", (IProduceMessages produceMessages) => produceMessages.Send("Hello, world!"));

app.Run();
