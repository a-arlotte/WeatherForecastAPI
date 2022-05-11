using System;
using System.Collections;
using System.Collections.Generic;

namespace WeatherForecastLibrary
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

    public class WeatherForecastCollection : List<WeatherForecast>
    {

        public WeatherForecastCollection()
        {

        }

    }
}
