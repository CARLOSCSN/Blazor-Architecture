﻿using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using Domain.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataEFCore.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly BlazorContext _context;        

        public ArtistRepository(BlazorContext context)
        {
            _context = context;
        }

        private async Task<bool> ArtistExists(int id, CancellationToken ct = default) =>
            await _context.Artist.AnyAsync(a => a.ArtistId == id, ct);

        public void Dispose() => _context.Dispose();

        public async Task<List<Artist>> GetAllAsync(CancellationToken ct = default) 
            => await _context.GetAllArtistsAsync();

        public async Task<Artist> GetByIdAsync(int id, CancellationToken ct = default)
        {
            var artist = await _context.GetArtistAsync(id);
            return artist.First();
        }

        public async Task<Artist> AddAsync(Artist newArtist, CancellationToken ct = default)
        {
            _context.Artist.Add(newArtist);
            await _context.SaveChangesAsync(ct);
            return newArtist;
        }

        public async Task<bool> UpdateAsync(Artist artist, CancellationToken ct = default)
        {
            if (!await ArtistExists(artist.ArtistId, ct))
                return false;
            _context.Artist.Update(artist);
            await _context.SaveChangesAsync(ct);
            return true;
        }

        public async Task<bool> DeleteAsync(int id, CancellationToken ct = default)
        {
            if (!await ArtistExists(id, ct))
                return false;
            var toRemove = _context.Artist.Find(id);
            _context.Artist.Remove(toRemove);
            await _context.SaveChangesAsync(ct);
            return true;
        }
    }
}