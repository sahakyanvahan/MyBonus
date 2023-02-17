using MyBonus.Api.services;

namespace MyBonus.Services.Tests;

public class UnitTest1
{
    [Fact]
    public void GetWeather_ShouldReturnSnow_WhenCalled()
    {
        var weatherService = new WeatherService();
        
        var result = weatherService.GetWeather();
        
        Assert.Equal("Snow", result);
    }
    
    // [Fact]
    // public void GetWeather_ShouldFail_ForTestingPurposes()
    // {
    //     var weatherService = new WeatherService();
    //     
    //     var result = weatherService.GetWeather();
    //     
    //     Assert.Equal("Rain", result);
    // }
}