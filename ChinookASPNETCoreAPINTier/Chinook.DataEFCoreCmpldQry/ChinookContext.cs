using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chinook.DataEFCoreCmpldQry.Configurations;
using Chinook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Chinook.DataEFCoreCmpldQry
{
    public class ChinookContext : DbContext
    {
        public static long InstanceCount;

        private static readonly Func<ChinookContext, IEnumerable<Album>> _queryGetAllAlbums =
            EF.CompileQuery((ChinookContext db) => db.Album.AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<Album>> _queryGetAlbum =
            EF.CompileQuery((ChinookContext db, int id) =>
                db.Album.Where(a => a.AlbumId == id).AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<Album>> _queryGetAlbumsByArtistId =
            EF.CompileQuery((ChinookContext db, int id) => db.Album.Where(a => a.ArtistId == id).AsNoTracking());

        private static readonly Func<ChinookContext, IEnumerable<Artist>> _queryGetAllArtists =
            EF.CompileQuery((ChinookContext db) => db.Artist.AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<Artist>> _queryGetArtist =
            EF.CompileQuery((ChinookContext db, int id) =>
                db.Artist.Where(a => a.ArtistId == id).AsNoTracking());

        private static readonly Func<ChinookContext, IEnumerable<Customer>> _queryGetAllCustomers =
            EF.CompileQuery((ChinookContext db) => db.Customer.AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<Customer>> _queryGetCustomer =
            EF.CompileQuery((ChinookContext db, int id) =>
                db.Customer.Where(c => c.CustomerId == id).AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<Customer>> _queryGetCustomerBySupportRepId =
            EF.CompileQuery((ChinookContext db, int id) =>
                db.Customer.Where(a => a.SupportRepId == id).AsNoTracking());

        private static readonly Func<ChinookContext, IEnumerable<Employee>> _queryGetAllEmployees =
            EF.CompileQuery((ChinookContext db) => db.Employee.AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<Employee>> _queryGetEmployee =
            EF.CompileQuery((ChinookContext db, int id) =>
                db.Employee.Where(e => e.EmployeeId == id).AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<Employee>> _queryGetDirectReports =
            EF.CompileQuery((ChinookContext db, int id) =>
                db.Employee.Where(e => e.ReportsTo == id).AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<Employee>> _queryGetReportsTo =
            EF.CompileQuery((ChinookContext db, int id) =>
                db.Employee.Where(e => e.ReportsTo == id).AsNoTracking());

        private static readonly Func<ChinookContext, IEnumerable<Genre>> _queryGetAllGenres =
            EF.CompileQuery((ChinookContext db) => db.Genre.AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<Genre>> _queryGetGenre =
            EF.CompileQuery((ChinookContext db, int id) =>
                db.Genre.Where(g => g.GenreId == id).AsNoTracking());

        private static readonly Func<ChinookContext, IEnumerable<InvoiceLine>> _queryGetAllInvoiceLines =
            EF.CompileQuery((ChinookContext db) => db.InvoiceLine.AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<InvoiceLine>> _queryGetInvoiceLine =
            EF.CompileQuery((ChinookContext db, int id) =>
                db.InvoiceLine.Where(i => i.InvoiceLineId == id).AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<InvoiceLine>> _queryGetInvoiceLinesByInvoiceId
            =
            EF.CompileQuery((ChinookContext db, int id) =>
                db.InvoiceLine.Where(a => a.InvoiceId == id).AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<InvoiceLine>> _queryGetInvoiceLinesByTrackId =
            EF.CompileQuery((ChinookContext db, int id) =>
                db.InvoiceLine.Where(a => a.TrackId == id).AsNoTracking());

        private static readonly Func<ChinookContext, IEnumerable<Invoice>> _queryGetAllInvoices =
            EF.CompileQuery((ChinookContext db) => db.Invoice.AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<Invoice>> _queryGetInvoice =
            EF.CompileQuery((ChinookContext db, int id) =>
                db.Invoice.Where(i => i.InvoiceId == id).AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<Invoice>> _queryGetInvoicesByCustomerId =
            EF.CompileQuery((ChinookContext db, int id) =>
                db.Invoice.Where(a => a.CustomerId == id).AsNoTracking());

        private static readonly Func<ChinookContext, IEnumerable<MediaType>> _queryGetAllMediaTypes =
            EF.CompileQuery((ChinookContext db) => db.MediaType.AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<MediaType>> _queryGetMediaType =
            EF.CompileQuery((ChinookContext db, int id) =>
                db.MediaType.Where(m => m.MediaTypeId == id).AsNoTracking());

        private static readonly Func<ChinookContext, IEnumerable<Playlist>> _queryGetAllPlaylists =
            EF.CompileQuery((ChinookContext db) => db.Playlist.AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<Playlist>> _queryGetPlaylist =
            EF.CompileQuery((ChinookContext db, int id) =>
                db.Playlist.Where(p => p.PlaylistId == id).AsNoTracking());

        private static readonly Func<ChinookContext, IEnumerable<PlaylistTrack>> _queryGetAllPlaylistTracks =
            EF.CompileQuery((ChinookContext db) => db.PlaylistTrack.AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<PlaylistTrack>>
            _queryGetPlaylistTrackByPlaylistId =
                EF.CompileQuery((ChinookContext db, int id) =>
                    db.PlaylistTrack.Where(a => a.PlaylistId == id).AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<PlaylistTrack>>
            _queryGetPlaylistTracksByTrackId =
                EF.CompileQuery((ChinookContext db, int id) =>
                    db.PlaylistTrack.Where(a => a.TrackId == id).AsNoTracking());

        private static readonly Func<ChinookContext, IEnumerable<Track>> _queryGetAllTracks =
            EF.CompileQuery((ChinookContext db) => db.Track.AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<Track>> _queryGetTrack =
            EF.CompileQuery((ChinookContext db, int id) =>
                db.Track.Where(t => t.TrackId == id).AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<Track>> _queryGetTracksByAlbumId =
            EF.CompileQuery((ChinookContext db, int id) =>
                db.Track.Where(a => a.AlbumId == id).AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<Track>> _queryGetTracksByGenreId =
            EF.CompileQuery((ChinookContext db, int id) =>
                db.Track.Where(a => a.GenreId == id).AsNoTracking());

        private static readonly Func<ChinookContext, int, IEnumerable<Track>> _queryGetTracksByMediaTypeId =
            EF.CompileQuery((ChinookContext db, int id) =>
                db.Track.Where(a => a.MediaTypeId == id).AsNoTracking());

        public ChinookContext(DbContextOptions options) : base(options)
        {
            //Interlocked.Increment(ref InstanceCount);
        }

        public virtual DbSet<Album> Album { get; set; }
        public virtual DbSet<Artist> Artist { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceLine> InvoiceLine { get; set; }
        public virtual DbSet<MediaType> MediaType { get; set; }
        public virtual DbSet<Playlist> Playlist { get; set; }
        public virtual DbSet<PlaylistTrack> PlaylistTrack { get; set; }
        public virtual DbSet<Track> Track { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AlbumConfiguration(modelBuilder.Entity<Album>());
            new ArtistConfiguration(modelBuilder.Entity<Artist>());
            new CustomerConfiguration(modelBuilder.Entity<Customer>());
            new EmployeeConfiguration(modelBuilder.Entity<Employee>());
            new GenreConfiguration(modelBuilder.Entity<Genre>());
            new InvoiceConfiguration(modelBuilder.Entity<Invoice>());
            new InvoiceLineConfiguration(modelBuilder.Entity<InvoiceLine>());
            new MediaTypeConfiguration(modelBuilder.Entity<MediaType>());
            new PlaylistConfiguration(modelBuilder.Entity<Playlist>());
            new PlaylistTrackConfiguration(modelBuilder.Entity<PlaylistTrack>());
            new TrackConfiguration(modelBuilder.Entity<Track>());
        }

        public async Task<List<Album>> GetAllAlbumsAsync() => _queryGetAllAlbums(this).ToList();

        public async Task<List<Album>> GetAlbumAsync(int id) => _queryGetAlbum(this, id).ToList();

        public async Task<List<Album>> GetAlbumsByArtistIdAsync(int id) =>
            _queryGetAlbumsByArtistId(this, id).ToList();

        public async Task<List<Artist>> GetAllArtistsAsync() => _queryGetAllArtists(this).ToList();

        public async Task<List<Artist>> GetArtistAsync(int id) => _queryGetArtist(this, id).ToList();

        public async Task<List<Customer>> GetAllCustomersAsync() => _queryGetAllCustomers(this).ToList();

        public async Task<List<Customer>> GetCustomerAsync(int id) => _queryGetCustomer(this, id).ToList();

        public async Task<List<Customer>> GetCustomerBySupportRepIdAsync(int id) =>
            _queryGetCustomerBySupportRepId(this, id).ToList();

        public async Task<List<Employee>> GetAllEmployeesAsync() => _queryGetAllEmployees(this).ToList();

        public async Task<List<Employee>> GetEmployeeAsync(int id) => _queryGetEmployee(this, id).ToList();

        public async Task<List<Employee>> GetEmployeeDirectReportsAsync(int id) =>
             _queryGetDirectReports(this, id).ToList();

        public async Task<List<Employee>> GetEmployeeGetReportsToAsync(int id) =>
            _queryGetReportsTo(this, id).ToList();

        public async Task<List<Genre>> GetAllGenresAsync() => _queryGetAllGenres(this).ToList();

        public async Task<List<Genre>> GetGenreAsync(int id) => _queryGetGenre(this, id).ToList();

        public async Task<List<InvoiceLine>> GetAllInvoiceLinesAsync() =>
            _queryGetAllInvoiceLines(this).ToList();

        public async Task<List<InvoiceLine>> GetInvoiceLineAsync(int id) =>
            _queryGetInvoiceLine(this, id).ToList();

        public async Task<List<InvoiceLine>> GetInvoiceLinesByInvoiceIdAsync(int id) =>
            _queryGetInvoiceLinesByInvoiceId(this, id).ToList();

        public async Task<List<InvoiceLine>> GetInvoiceLinesByTrackIdAsync(int id) =>
            _queryGetInvoiceLinesByTrackId(this, id).ToList();

        public async Task<List<Invoice>> GetAllInvoicesAsync() => _queryGetAllInvoices(this).ToList();

        public async Task<List<Invoice>> GetInvoiceAsync(int id) => _queryGetInvoice(this, id).ToList();

        public async Task<List<Invoice>> GetInvoicesByCustomerIdAsync(int id) =>
            _queryGetInvoicesByCustomerId(this, id).ToList();

        public async Task<List<MediaType>> GetAllMediaTypesAsync() => _queryGetAllMediaTypes(this).ToList();

        public async Task<List<MediaType>> GetMediaTypeAsync(int id) =>
            _queryGetMediaType(this, id).ToList();

        public async Task<List<Playlist>> GetAllPlaylistsAsync() => _queryGetAllPlaylists(this).ToList();

        public async Task<List<Playlist>> GetPlaylistAsync(int id) => _queryGetPlaylist(this, id).ToList();

        public async Task<List<PlaylistTrack>> GetAllPlaylistTracksAsync() =>
            _queryGetAllPlaylistTracks(this).ToList();

        public async Task<List<PlaylistTrack>> GetPlaylistTrackByPlaylistId(int id) =>
            _queryGetPlaylistTrackByPlaylistId(this, id).ToList();

        public async Task<List<PlaylistTrack>> GetPlaylistTracksByTrackIdAsync(int id) =>
            _queryGetPlaylistTracksByTrackId(this, id).ToList();

        public async Task<List<Track>> GetAllTracksAsync() => _queryGetAllTracks(this).ToList();

        public async Task<List<Track>> GetTrackAsync(int id) => _queryGetTrack(this, id).ToList();

        public async Task<List<Track>> GetTracksByAlbumIdAsync(int id) =>
            _queryGetTracksByAlbumId(this, id).ToList();

        public async Task<List<Track>> GetTracksByGenreIdAsync(int id) =>
            _queryGetTracksByGenreId(this, id).ToList();

        public async Task<List<Track>> GetTracksByMediaTypeIdAsync(int id) =>
            _queryGetTracksByMediaTypeId(this, id).ToList();
    }
}