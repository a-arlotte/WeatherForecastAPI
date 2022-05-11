using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDeployTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        //Test Variables
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public List<WeatherForecast> GetTestWeatherForecasts()
        {
            //create test list of weather forecasts
            return new List<WeatherForecast>()
            {
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary = "Chilly",
                    TemperatureC = 10
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary = "Freezing",
                    TemperatureC = 0
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary = "Warm",
                    TemperatureC = 20
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary = "Hot",
                    TemperatureC = 25
                }
            };
        }


        List<WeatherForecast> weatherForecasts = new List<WeatherForecast>();

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        public WeatherForecastController()
        {
            this.weatherForecasts = GetTestWeatherForecasts();
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> GetAllWeatherForecasts()
        {
            return weatherForecasts;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> GetRandom()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }


        [HttpGet]
        public WeatherForecast GetFirstChilly()
        {
            return weatherForecasts.First(w => w.Summary == "Chilly");
        }


    }
}
