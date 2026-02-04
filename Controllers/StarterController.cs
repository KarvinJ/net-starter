using Microsoft.AspNetCore.Mvc;
using Starter.Services;

namespace Starter.Controllers;

[ApiController]
[Route("[controller]")]
public class StarterController(IStarterService starterService) : ControllerBase
{
    [HttpGet("{name}")]
    public ActionResult<string> Hello(string name)
    {
        return Ok(starterService.Hello(name));
    }
}