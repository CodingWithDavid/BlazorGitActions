using GitActions.Data;

namespace GitActionTest
{
    public class WeatherServiceTest
    {
        [Fact]
        public async Task Get5ItemsPositiveTest()
        {
            WeatherForecastService service = new();
            var items = await service.GetForecastAsync(DateTime.Now);
            Assert.NotNull(items);
            Assert.Equal(5, items.Length);
        }
    }
}