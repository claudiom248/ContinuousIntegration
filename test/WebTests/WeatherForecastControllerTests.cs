using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json.Linq;

namespace WebTests
{

    public class WeatherForecastControllerTests : ControllerTestsFixture
    {
        public WeatherForecastControllerTests(WebApplicationFactory<Program> factory) : base(factory) { }

        [Fact]
        public async Task Get_WeatherForecast_ReturnSuccessAndJsonResponse()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/weatherforecast");
            var json = await GetJson(response);

            response.EnsureSuccessStatusCode();
            Assert.True(json.Type == JTokenType.Array);
        }

        private static async Task<JToken> GetJson(HttpResponseMessage response) => JToken.Parse(await response.Content.ReadAsStringAsync());
    }
}