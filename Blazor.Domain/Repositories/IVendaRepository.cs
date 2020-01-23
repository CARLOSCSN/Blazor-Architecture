using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface IVendaRepository : IDisposable
    {
        Task<List<Venda>> GetAllAsync(CancellationToken ct = default);
        Task<Venda> GetByIdAsync(int id, CancellationToken ct = default);
        Task<Venda> AddAsync(Venda newVenda, CancellationToken ct = default);
        Task<bool> UpdateAsync(Venda Venda, CancellationToken ct = default);
        Task<bool> DeleteAsync(int id, CancellationToken ct = default);
    }
}