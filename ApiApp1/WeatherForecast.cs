using System;

namespace ApiApp1
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public string Name { get; set; }

        public string Summary { get; set; }
    }
}
