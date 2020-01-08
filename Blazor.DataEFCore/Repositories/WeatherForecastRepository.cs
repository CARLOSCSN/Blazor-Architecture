using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using Blazor.Domain.Repositories;
using Blazor.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blazor.DataEFCore.Repositories
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        private readonly BlazorContext _context;

        public WeatherForecastRepository(BlazorContext context)
        {
            _context = context;
        }

        private async Task<bool> WeatherForecastExists(int id, CancellationToken ct = default) =>
            await _context.WeatherForecast.AnyAsync(a => a.WeatherForecastId == id, ct);

        public void Dispose() => _context.Dispose();

        public async Task<List<WeatherForecast>> GetAllAsync(CancellationToken ct = default) 
            => await _context.GetAllWeatherForecastAsync();

        public async Task<WeatherForecast> GetByIdAsync(int id, CancellationToken ct = default)
        {
            var album = await _context.GetWeatherForecastAsync(id);
            return album.First();
        }

        public async Task<WeatherForecast> AddAsync(WeatherForecast entity, CancellationToken ct = default)
        {
            _context.WeatherForecast.Add(entity);
            await _context.SaveChangesAsync(ct);
            return entity;
        }

        public async Task<bool> UpdateAsync(WeatherForecast entity, CancellationToken ct = default)
        {
            if (!await WeatherForecastExists(entity.WeatherForecastId, ct))
                return false;
            _context.WeatherForecast.Update(entity);

            _context.Update(entity);
            await _context.SaveChangesAsync(ct);
            return true;
        }

        public async Task<bool> DeleteAsync(int id, CancellationToken ct = default)
        {
            if (!await WeatherForecastExists(id, ct))
                return false;
            var toRemove = _context.WeatherForecast.Find(id);
            _context.WeatherForecast.Remove(toRemove);
            await _context.SaveChangesAsync(ct);
            return true;
        }
    }
}