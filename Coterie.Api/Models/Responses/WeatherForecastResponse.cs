using System;

namespace Coterie.Api.Models.Responses
{
    public class WeatherForecastResponse
    {
        public DateTime Date;

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int) (TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}