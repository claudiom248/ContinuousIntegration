namespace Web.Services
{
    internal class WeatherForecastService : IWeatherForecastService
    {
        private static string[] _summaries = new[]
        {
            "Freezing", 
            "Bracing", 
            "Chilly", 
            "Cool", 
            "Mild", 
            "Warm", 
            "Balmy", 
            "Hot", 
            "Sweltering", 
            "Scorching"
        };

        public Task<List<WeatherForecast>> GetWeatherForecast()
        {
            var result = GetWeatherForecastCore().ToList();
            return Task.FromResult(result);
        }

        public void UncoveredMethod()
        {
            throw new NotImplementedException();
        }

        private static IEnumerable<WeatherForecast> GetWeatherForecastCore()
        {
            return Enumerable.Range(1, 5)
                .Select(CreateWeatherForecast());
        }

        private static Func<int, WeatherForecast> CreateWeatherForecast() => index =>
            new WeatherForecast
            (
                DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                Random.Shared.Next(-20, 55),
                _summaries[Random.Shared.Next(_summaries.Length)]
            );
    }
}
