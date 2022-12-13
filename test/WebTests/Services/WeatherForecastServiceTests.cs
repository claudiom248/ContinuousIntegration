using Web.Services;

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

        [Fact]
        //public void UncoveredMethod_Throws()
        //{
        //    var sut = new WeatherForecastService();
        //    Assert.Throws<NotImplementedException>(sut.UncoveredMethod);
        //}

        [Theory]
        [InlineData(true, 1, 1)]
        [InlineData(true, 2, 2)]
        [InlineData(true, 3, 3)]
        [InlineData(false, 1, 0)]
        [InlineData(false, 2, 1)]
        public void PartiallyCovedereMethod_Branch1(bool flag, byte param, int expected)
        {
            var sut = new WeatherForecastService();
            var result = sut.PartiallyCoveredMethod(flag, param);
            Assert.Equal(expected, result);
        }
    }
}
