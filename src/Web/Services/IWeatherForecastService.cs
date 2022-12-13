namespace Web.Services
{
    internal interface IWeatherForecastService
    {
        Task<List<WeatherForecast>> GetWeatherForecast();
        int PartiallyCoveredMethod(bool flag, byte param);
        //void UncoveredMethod();
    }
}
