using Microsoft.AspNetCore.Mvc;
using Starter.Models;
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
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Character>>>  GetAll()
    {
        return Ok(await starterService.GetAll());
    }
}