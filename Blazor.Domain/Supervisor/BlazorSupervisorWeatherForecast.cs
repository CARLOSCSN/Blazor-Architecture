using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Extensions;
using Domain.ApiModels;
using Domain.Entities;
using Microsoft.Extensions.Caching.Memory;

namespace Domain.Supervisor
{
    public partial class BlazorSupervisor
    {
        public async Task<IEnumerable<WeatherForecastApiModel>> GetAllWeatherForecastAsync(CancellationToken ct = default)
        {
            var WeatherForecasts = await _weatherForecastRepository.GetAllAsync(ct);
            foreach (var WeatherForecast in WeatherForecasts)
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(WeatherForecast.WeatherForecastId, WeatherForecast, cacheEntryOptions);
            }
            return WeatherForecasts.ConvertAll();
        }

        public async Task<WeatherForecastApiModel> GetWeatherForecastByIdAsync(int id, CancellationToken ct = default)
        {
            var WeatherForecast = _cache.Get<WeatherForecast>(id);
            var WeatherForecastApiModel = WeatherForecast.Convert();
            return WeatherForecastApiModel;
        }

        public async Task<WeatherForecastApiModel> AddWeatherForecastAsync(WeatherForecastApiModel newWeatherForecastApiModel,
            CancellationToken ct = default)
        {
            var WeatherForecast = newWeatherForecastApiModel.Convert();

            WeatherForecast = await _weatherForecastRepository.AddAsync(WeatherForecast, ct);
            newWeatherForecastApiModel.WeatherForecastId = WeatherForecast.WeatherForecastId;
            return newWeatherForecastApiModel;
        }

        public async Task<bool> UpdateWeatherForecastAsync(WeatherForecastApiModel WeatherForecastApiModel,
            CancellationToken ct = default)
        {
            var WeatherForecast = await _weatherForecastRepository.GetByIdAsync(WeatherForecastApiModel.WeatherForecastId, ct);

            if (WeatherForecast is null) return false;
            WeatherForecast.WeatherForecastId = WeatherForecastApiModel.WeatherForecastId;

            return await _weatherForecastRepository.UpdateAsync(WeatherForecast, ct);
        }

        public Task<bool> DeleteWeatherForecastAsync(int id, CancellationToken ct = default)
            => _weatherForecastRepository.DeleteAsync(id, ct);
    }
}