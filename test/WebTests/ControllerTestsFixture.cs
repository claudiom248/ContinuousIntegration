using Microsoft.AspNetCore.Mvc.Testing;

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
}