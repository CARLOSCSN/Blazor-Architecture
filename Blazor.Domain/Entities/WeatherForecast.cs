using Blazor.Domain.Converters;
using Blazor.Domain.ApiModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System;

namespace Blazor.Domain.Entities
{
    public sealed class WeatherForecast : IConvertModel<WeatherForecast, WeatherForecastApiModel>
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WeatherForecastId { get; set; }

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public WeatherForecastApiModel Convert() => new WeatherForecastApiModel
        {
            WeatherForecastId = WeatherForecastId,
            Date = Date,
            TemperatureC = TemperatureC,
            //TemperatureF = TemperatureF,
            Summary = Summary
        };
    }
}