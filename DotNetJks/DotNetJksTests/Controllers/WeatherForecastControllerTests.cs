using DotNetJks.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
namespace DotNetJksTests.Controllers
{
    public class WeatherForecastControllerTests
    {
        private readonly WeatherForecastController _weatherForecastController;
        private readonly Mock<ILogger<WeatherForecastController>> _loggerMock;
        
        public WeatherForecastControllerTests()
        {
            _loggerMock = new Mock<ILogger<WeatherForecastController>>();
            _weatherForecastController = new WeatherForecastController(_loggerMock.Object);
        }

        [Fact]
        public async Task GetWeatherForecast_Returns_Non_Null_Or_Empty()
        {
            var result = _weatherForecastController.Get();

            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }
    }
}
