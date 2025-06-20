using Microsoft.AspNetCore.Mvc;
using Starter.Services;

namespace Starter.Controllers;

[ApiController]
[Route("[controller]")]
public class StarterController(IStarterService starterService) : ControllerBase
{
    [HttpGet("{name}")]
    public string Get(string name)
    {
        return starterService.Hello(name);
    }
}