using Blazor.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;

namespace Blazor.DataEFCore.Configurations
{
    public class WeatherForecastConfiguration
    {
        public WeatherForecastConfiguration(EntityTypeBuilder<WeatherForecast> entity)
        {
            entity
            .Property(f => f.WeatherForecastId)
            .ValueGeneratedOnAdd();

            entity
                .HasData(
                new WeatherForecast() { WeatherForecastId = 1, Date = DateTime.Now, TemperatureC = -10, Summary = "Warm" },
                new WeatherForecast() { WeatherForecastId = 2, Date = DateTime.Now.AddDays(3), TemperatureC = 45, Summary = "Very Hot" },
                new WeatherForecast() { WeatherForecastId = 3, Date = DateTime.Now.AddDays(6), TemperatureC = 12, Summary = "Bracing" },
                new WeatherForecast() { WeatherForecastId = 4, Date = DateTime.Now, TemperatureC = 50, Summary = "Frying" },
                new WeatherForecast() { WeatherForecastId = 5, Date = DateTime.Now.AddDays(14), TemperatureC = 2, Summary = "Cold" },
                new WeatherForecast() { WeatherForecastId = 6, Date = DateTime.Now.AddDays(60), TemperatureC = -5, Summary = "Very Cold" },
                new WeatherForecast() { WeatherForecastId = 7, Date = DateTime.Now, TemperatureC = 40, Summary = "Hot" },
                new WeatherForecast() { WeatherForecastId = 8, Date = DateTime.Now.AddDays(33), TemperatureC = 22, Summary = "Good" },
                new WeatherForecast() { WeatherForecastId = 9, Date = DateTime.Now.AddDays(79), TemperatureC = 35, Summary = "Summer" },
                new WeatherForecast() { WeatherForecastId = 10, Date = DateTime.Now, TemperatureC = 55, Summary = "Warm" });

            //entity.HasIndex(e => e.ArtistId)
            //    .HasName("IFK_Artist_Album");

            //entity.Property(e => e.Title)
            //    .IsRequired()
            //    .HasMaxLength(160);

            //entity.HasOne(d => d.Artist)
            //    .WithMany(p => p.Albums)
            //    .HasForeignKey(d => d.ArtistId)
            //    .OnDelete(DeleteBehavior.Restrict)
            //    .HasConstraintName("FK__Album__ArtistId__276EDEB3");
        }
    }
}