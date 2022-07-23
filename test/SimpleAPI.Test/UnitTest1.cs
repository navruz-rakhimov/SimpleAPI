using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{
    WeatherForecastController controller = new WeatherForecastController();

    [Fact]
    public void GetReturnsMyName()
    {
        var returnvalue = controller.Get();
        Assert.Equal("Navruz", returnvalue.Value);
    }

    [Fact]
    public void Test1()
    {

    }
}