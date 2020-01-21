using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Converters;
using Domain.Entities;
using Newtonsoft.Json;

namespace Domain.ApiModels
{
    public class WeatherForecastApiModel : IConvertModel<WeatherForecastApiModel, WeatherForecast>
    {

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int WeatherForecastId { get; set; }

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public WeatherForecast Convert() => new WeatherForecast
        {
            WeatherForecastId = WeatherForecastId,
            Date = Date,
            TemperatureC = TemperatureC,
            //TemperatureF = TemperatureF,
            Summary = Summary
        };
    }
}