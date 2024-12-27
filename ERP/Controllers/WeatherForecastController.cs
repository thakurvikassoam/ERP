using Microsoft.AspNetCore.Mvc;

namespace ERP.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet("TestApi")]
    public IActionResult Getdata() 
    {
       return Ok("Hello World");

    }
}
