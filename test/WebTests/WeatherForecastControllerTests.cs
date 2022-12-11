using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json.Linq;

namespace WebTests
{
    public class ControllerTestsFixture : IClassFixture<WebApplicationFactory<Program>>
    {
        protected readonly WebApplicationFactory<Program> _factory;

        public ControllerTestsFixture(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }
    }

    public class WeatherForecastControllerTests : ControllerTestsFixture
    {
        public WeatherForecastControllerTests(WebApplicationFactory<Program> factory) : base(factory) { }

        [Fact]
        public async Task Get_WeaterForecast_ReturnSuccessAndJsonResponse()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/weatherforecast");
            var responseContentAsString = await response.Content.ReadAsStringAsync();
            var jsonToken = JToken.Parse(responseContentAsString);

            response.EnsureSuccessStatusCode();
            Assert.True(jsonToken.Type == JTokenType.Object);
        }
    }
}