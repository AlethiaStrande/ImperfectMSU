using Microsoft.AspNetCore.Mvc;

namespace Imperfect.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImperfectController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<ImperfectController> _logger;

        public ImperfectController(ILogger<ImperfectController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //friendrequest
        [HttpGet(Name = "Person")]
        public String Get()
        {
            return new Person().successString;
        }
        //get person (søke på person)

        //post -> legge ut bilde/post
    }
}