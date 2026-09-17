using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        private List<WeatherForecast> weatherForecasts = new List<WeatherForecast>();

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("{days}",Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> GetWithDays([FromRoute] int days)
        {
            return Enumerable.Range(1, days).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("filter", Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> GetFiltered([FromQuery] int minTemp, [FromQuery] int maxTemp)
        {
            var data = Enumerable.Range(1, 15).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
            return data.Where(w => w.TemperatureC >= minTemp && w.TemperatureC <= maxTemp);
        }
        public string AddForecast([FromBody] WeatherForecast Forecast)
        {
            weatherForecasts.Add(Forecast);
            return "пвпа";
        }
    }
}
