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
        public async Task<IEnumerable<VendaApiModel>> GetAllVendaAsync(CancellationToken ct = default)
        {
            var Vendas = await _vendaRepository.GetAllAsync(ct);
            foreach (var Venda in Vendas)
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(Venda.VendaId, Venda, cacheEntryOptions);
            }
            return Vendas.ConvertAll();
        }

        public async Task<VendaApiModel> GetVendaByIdAsync(int id, CancellationToken ct = default)
        {
            var Venda = _cache.Get<Venda>(id);
            var VendaApiModel = Venda.Convert();
            return VendaApiModel;
        }

        public async Task<VendaApiModel> AddVendaAsync(VendaApiModel newVendaApiModel,
            CancellationToken ct = default)
        {
            var Venda = newVendaApiModel.Convert();

            Venda = await _vendaRepository.AddAsync(Venda, ct);
            newVendaApiModel.VendaId = Venda.VendaId;
            return newVendaApiModel;
        }

        public async Task<bool> UpdateVendaAsync(VendaApiModel VendaApiModel,
            CancellationToken ct = default)
        {
            var Venda = await _vendaRepository.GetByIdAsync(VendaApiModel.VendaId, ct);

            if (Venda is null) return false;
            Venda.VendaId = VendaApiModel.VendaId;

            return await _vendaRepository.UpdateAsync(Venda, ct);
        }

        public Task<bool> DeleteVendaAsync(int id, CancellationToken ct = default)
            => _vendaRepository.DeleteAsync(id, ct);
    }
}