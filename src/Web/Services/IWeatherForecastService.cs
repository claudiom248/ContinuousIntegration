namespace Web.Services
{
    internal interface IWeatherForecastService
    {
        Task<List<WeatherForecast>> GetWeatherForecast();
    }
}
