using Rest_Api_Test.Controllers;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));

//Log.Logger = new LoggerConfiguration()
//    .WriteTo.Http(
//        requestUri: "http://localhost:3100/",
//        textFormatter: new Serilog.Formatting.Json.JsonFormatter())
//    .Enrich.WithProperty("app", "my-dotnet-app")
//    .Enrich.WithProperty("env", "development")
//    .CreateLogger();

Log.Information("Hello, Loki!");

builder.Services.AddControllers();

// Configure Serilog
//Log.Logger = new LoggerConfiguration()
//    .ReadFrom.Configuration(builder.Configuration) // Read from appsettings.json
//    .Enrich.FromLogContext()
//    .WriteTo.Console()
//    .CreateLogger();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddSingleton<Serilog.ILogger, Logger>();
//builder.Services.AddSingleton<ILoggerFactory, LoggerFactory>();
//builder.Services.AddSingleton(typeof(ILogger<>), typeof(Logger<>));

//builder.Services.AddTransient<GetMockDataController>();

var app = builder.Build();
//app.UseSerilogRequestLogging();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
