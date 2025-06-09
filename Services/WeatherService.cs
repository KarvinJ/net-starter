using Starter.Models;

namespace Starter.Services;

public interface IWeatherService
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Weather[] WeatherList();
}

/// <inheritdoc />
public class WeatherService : IWeatherService
{
    /// <summary>
    /// 
    /// </summary>
    public WeatherService()
    {
    }

    /// <inheritdoc />
    public Weather[] WeatherList()
    { 
        string[] summaries =
        [
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
        ];
        
        return Enumerable.Range(1, 5).Select(index => new Weather
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaries[Random.Shared.Next(summaries.Length)]
            }
        ).ToArray();
    }
}