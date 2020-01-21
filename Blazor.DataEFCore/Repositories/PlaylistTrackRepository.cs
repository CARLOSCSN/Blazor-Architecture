﻿using System;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using Domain.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataEFCore.Repositories
{
    public class PlaylistTrackRepository : IPlaylistTrackRepository
    {
        private readonly BlazorContext _context;

        public PlaylistTrackRepository(BlazorContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        private async Task<bool> PlaylistTrackExists(int id, CancellationToken ct = default) =>
            await _context.PlaylistTrack.AnyAsync(pt => pt.PlaylistId == id, ct);

        public void Dispose() => _context.Dispose();

        public async Task<List<PlaylistTrack>> GetAllAsync(CancellationToken ct = default) 
            => await _context.GetAllPlaylistTracksAsync();

        public async Task<List<PlaylistTrack>> GetByPlaylistIdAsync(int id,
            CancellationToken ct = default) => await _context.GetPlaylistTrackByPlaylistId(id);

        public async Task<List<PlaylistTrack>> GetByTrackIdAsync(int id,
            CancellationToken ct = default) => await _context.GetPlaylistTracksByTrackIdAsync(id);

        public async Task<PlaylistTrack> AddAsync(PlaylistTrack newPlaylistTrack,
            CancellationToken ct = default)
        {
            _context.PlaylistTrack.Add(newPlaylistTrack);
            await _context.SaveChangesAsync(ct);
            return newPlaylistTrack;
        }

        public async Task<bool> UpdateAsync(PlaylistTrack playlistTrack,
            CancellationToken ct = default)
        {
            if (!await PlaylistTrackExists(playlistTrack.PlaylistId, ct))
                return false;
            _context.PlaylistTrack.Update(playlistTrack);
            await _context.SaveChangesAsync(ct);
            return true;
        }

        public async Task<bool> DeleteAsync(int id, CancellationToken ct = default)
        {
            if (!await PlaylistTrackExists(id, ct))
                return false;
            var toRemove = _context.PlaylistTrack.Find(id);
            _context.PlaylistTrack.Remove(toRemove);
            await _context.SaveChangesAsync(ct);
            return true;
        }
    }
}