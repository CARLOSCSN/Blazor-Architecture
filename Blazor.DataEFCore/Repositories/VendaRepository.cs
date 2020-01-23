using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using Domain.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataEFCore.Repositories
{
    public class VendaRepository : IVendaRepository
    {
        private readonly BlazorContext _context;

        public VendaRepository(BlazorContext context)
        {
            _context = context;
        }

        private async Task<bool> VendaExists(int id, CancellationToken ct = default) =>
            await _context.Venda.AnyAsync(a => a.VendaId == id, ct);

        public void Dispose() => _context.Dispose();

        public async Task<List<Venda>> GetAllAsync(CancellationToken ct = default) 
            => await _context.GetAllVendaAsync();

        public async Task<Venda> GetByIdAsync(int id, CancellationToken ct = default)
        {
            var album = await _context.GetVendaAsync(id);
            return album.First();
        }

        public async Task<Venda> AddAsync(Venda entity, CancellationToken ct = default)
        {
            _context.Venda.Add(entity);
            await _context.SaveChangesAsync(ct);
            return entity;
        }

        public async Task<bool> UpdateAsync(Venda entity, CancellationToken ct = default)
        {
            if (!await VendaExists(entity.VendaId, ct))
                return false;
            _context.Venda.Update(entity);

            _context.Update(entity);
            await _context.SaveChangesAsync(ct);
            return true;
        }

        public async Task<bool> DeleteAsync(int id, CancellationToken ct = default)
        {
            if (!await VendaExists(id, ct))
                return false;
            var toRemove = _context.Venda.Find(id);
            _context.Venda.Remove(toRemove);
            await _context.SaveChangesAsync(ct);
            return true;
        }
    }
}