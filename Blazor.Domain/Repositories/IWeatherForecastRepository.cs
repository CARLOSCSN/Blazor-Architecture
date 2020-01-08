using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Blazor.Domain.Entities;

namespace Blazor.Domain.Repositories
{
    public interface IWeatherForecastRepository : IDisposable
    {
        Task<List<WeatherForecast>> GetAllAsync(CancellationToken ct = default);
        Task<WeatherForecast> GetByIdAsync(int id, CancellationToken ct = default);
        Task<WeatherForecast> AddAsync(WeatherForecast newWeatherForecast, CancellationToken ct = default);
        Task<bool> UpdateAsync(WeatherForecast WeatherForecast, CancellationToken ct = default);
        Task<bool> DeleteAsync(int id, CancellationToken ct = default);
    }
}