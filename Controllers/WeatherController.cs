using Microsoft.AspNetCore.Mvc;
using Starter.Models;
using Starter.Services;

namespace Starter.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherController : ControllerBase
{
    private readonly IWeatherService _weatherService;

    public WeatherController(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    [HttpGet]
    public IEnumerable<Weather> Get()
    {
        return _weatherService.WeatherList();
    }
}