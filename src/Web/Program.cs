using Microsoft.AspNetCore.Mvc;
using Web.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IWeatherForecastService, WeatherForecastService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/weatherforecast", ([FromServices] IWeatherForecastService weatherForecastService) => weatherForecastService.GetWeatherForecast())
    .WithName("GetWeatherForecast")
    .WithOpenApi();

app.Run();

public partial class Program { }