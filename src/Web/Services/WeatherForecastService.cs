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

        public int PartiallyCoveredMethod(bool flag, byte param)
        {
            if (flag) 
            {
                if (param == 1)
                {
                    return 1;
                }
                else if (param == 2) 
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
            else
            {
                if (param == 1)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
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
