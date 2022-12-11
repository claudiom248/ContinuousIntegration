﻿using Web.Services;

namespace WebTests.Services
{
    public class WeatherForecastServiceTests
    {
        [Fact]
        public async Task GetWeatherForecast_ListWeatherForecast()
        {
            var sut = new WeatherForecastService();
            var weatherForecast = await sut.GetWeatherForecast();
            Assert.NotEmpty(weatherForecast);
        }
    }
}