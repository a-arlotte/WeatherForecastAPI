using System;
using System.Collections.Generic;

namespace WeatherForecastLibrary
{
    public class WeatherForecastLibrary
    {

        //Test Variables
        public static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public static WeatherForecastCollection GetTestWeatherForecasts()
        {
            //create test list of weather forecasts
            return new WeatherForecastCollection()
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
    }
}
