using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecastLibrary;

namespace WeatherForecastAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private IEnumerable<WeatherForecast> weatherForecasts = WeatherForecastLibrary.WeatherForecastLibrary.GetTestWeatherForecasts();

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public IEnumerable<WeatherForecast> GetAll()
        {
            return weatherForecasts;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> GetRandom()
        {
            var rng = new Random();
            string[] Summaries = WeatherForecastLibrary.WeatherForecastLibrary.Summaries;
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
