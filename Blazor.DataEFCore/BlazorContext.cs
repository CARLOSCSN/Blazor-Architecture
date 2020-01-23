using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataEFCore.Configurations;
using DataEFCore.IdentityModel;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataEFCore
{
    public class BlazorContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public static long InstanceCount;

        /// <summary>
        /// 01 - CompileQuery
        /// </summary>

        private static readonly Func<BlazorContext, IEnumerable<Album>> _queryGetAllAlbums =
            EF.CompileQuery((BlazorContext db) => db.Album.AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<Album>> _queryGetAlbum =
            EF.CompileQuery((BlazorContext db, int id) =>
                db.Album.Where(a => a.AlbumId == id).AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<Album>> _queryGetAlbumsByArtistId =
            EF.CompileQuery((BlazorContext db, int id) => db.Album.Where(a => a.ArtistId == id).AsNoTracking());

        private static readonly Func<BlazorContext, IEnumerable<Artist>> _queryGetAllArtists =
            EF.CompileQuery((BlazorContext db) => db.Artist.AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<Artist>> _queryGetArtist =
            EF.CompileQuery((BlazorContext db, int id) =>
                db.Artist.Where(a => a.ArtistId == id).AsNoTracking());

        private static readonly Func<BlazorContext, IEnumerable<Customer>> _queryGetAllCustomers =
            EF.CompileQuery((BlazorContext db) => db.Customer.AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<Customer>> _queryGetCustomer =
            EF.CompileQuery((BlazorContext db, int id) =>
                db.Customer.Where(c => c.CustomerId == id).AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<Customer>> _queryGetCustomerBySupportRepId =
            EF.CompileQuery((BlazorContext db, int id) =>
                db.Customer.Where(a => a.SupportRepId == id).AsNoTracking());

        private static readonly Func<BlazorContext, IEnumerable<Employee>> _queryGetAllEmployees =
            EF.CompileQuery((BlazorContext db) => db.Employee.AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<Employee>> _queryGetEmployee =
            EF.CompileQuery((BlazorContext db, int id) =>
                db.Employee.Where(e => e.EmployeeId == id).AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<Employee>> _queryGetDirectReports =
            EF.CompileQuery((BlazorContext db, int id) =>
                db.Employee.Where(e => e.ReportsTo == id).AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<Employee>> _queryGetReportsTo =
            EF.CompileQuery((BlazorContext db, int id) =>
                db.Employee.Where(e => e.ReportsTo == id).AsNoTracking());

        private static readonly Func<BlazorContext, IEnumerable<Genre>> _queryGetAllGenres =
            EF.CompileQuery((BlazorContext db) => db.Genre.AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<Genre>> _queryGetGenre =
            EF.CompileQuery((BlazorContext db, int id) =>
                db.Genre.Where(g => g.GenreId == id).AsNoTracking());

        private static readonly Func<BlazorContext, IEnumerable<InvoiceLine>> _queryGetAllInvoiceLines =
            EF.CompileQuery((BlazorContext db) => db.InvoiceLine.AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<InvoiceLine>> _queryGetInvoiceLine =
            EF.CompileQuery((BlazorContext db, int id) =>
                db.InvoiceLine.Where(i => i.InvoiceLineId == id).AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<InvoiceLine>> _queryGetInvoiceLinesByInvoiceId
            =
            EF.CompileQuery((BlazorContext db, int id) =>
                db.InvoiceLine.Where(a => a.InvoiceId == id).AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<InvoiceLine>> _queryGetInvoiceLinesByTrackId =
            EF.CompileQuery((BlazorContext db, int id) =>
                db.InvoiceLine.Where(a => a.TrackId == id).AsNoTracking());

        private static readonly Func<BlazorContext, IEnumerable<Invoice>> _queryGetAllInvoices =
            EF.CompileQuery((BlazorContext db) => db.Invoice.AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<Invoice>> _queryGetInvoice =
            EF.CompileQuery((BlazorContext db, int id) =>
                db.Invoice.Where(i => i.InvoiceId == id).AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<Invoice>> _queryGetInvoicesByCustomerId =
            EF.CompileQuery((BlazorContext db, int id) =>
                db.Invoice.Where(a => a.CustomerId == id).AsNoTracking());

        private static readonly Func<BlazorContext, IEnumerable<MediaType>> _queryGetAllMediaTypes =
            EF.CompileQuery((BlazorContext db) => db.MediaType.AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<MediaType>> _queryGetMediaType =
            EF.CompileQuery((BlazorContext db, int id) =>
                db.MediaType.Where(m => m.MediaTypeId == id).AsNoTracking());

        private static readonly Func<BlazorContext, IEnumerable<Playlist>> _queryGetAllPlaylists =
            EF.CompileQuery((BlazorContext db) => db.Playlist.AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<Playlist>> _queryGetPlaylist =
            EF.CompileQuery((BlazorContext db, int id) =>
                db.Playlist.Where(p => p.PlaylistId == id).AsNoTracking());

        private static readonly Func<BlazorContext, IEnumerable<PlaylistTrack>> _queryGetAllPlaylistTracks =
            EF.CompileQuery((BlazorContext db) => db.PlaylistTrack.AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<PlaylistTrack>>
            _queryGetPlaylistTrackByPlaylistId =
                EF.CompileQuery((BlazorContext db, int id) =>
                    db.PlaylistTrack.Where(a => a.PlaylistId == id).AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<PlaylistTrack>>
            _queryGetPlaylistTracksByTrackId =
                EF.CompileQuery((BlazorContext db, int id) =>
                    db.PlaylistTrack.Where(a => a.TrackId == id).AsNoTracking());

        private static readonly Func<BlazorContext, IEnumerable<Track>> _queryGetAllTracks =
            EF.CompileQuery((BlazorContext db) => db.Track.AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<Track>> _queryGetTrack =
            EF.CompileQuery((BlazorContext db, int id) =>
                db.Track.Where(t => t.TrackId == id).AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<Track>> _queryGetTracksByAlbumId =
            EF.CompileQuery((BlazorContext db, int id) =>
                db.Track.Where(a => a.AlbumId == id).AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<Track>> _queryGetTracksByGenreId =
            EF.CompileQuery((BlazorContext db, int id) =>
                db.Track.Where(a => a.GenreId == id).AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<Track>> _queryGetTracksByMediaTypeId =
            EF.CompileQuery((BlazorContext db, int id) =>
                db.Track.Where(a => a.MediaTypeId == id).AsNoTracking());

        private static readonly Func<BlazorContext, IEnumerable<WeatherForecast>> _queryGetAllWeatherForecast =
            EF.CompileQuery((BlazorContext db) => db.WeatherForecast.AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<WeatherForecast>> _queryGetWeatherForecast =
            EF.CompileQuery((BlazorContext db, int id) =>
                db.WeatherForecast.Where(a => a.WeatherForecastId == id).AsNoTracking());


        /// <summary>
        /// Venda
        /// </summary>
        private static readonly Func<BlazorContext, IEnumerable<Venda>> _queryGetAllVenda =
            EF.CompileQuery((BlazorContext db) => db.Venda.AsNoTracking());

        private static readonly Func<BlazorContext, int, IEnumerable<Venda>> _queryGetVenda =
            EF.CompileQuery((BlazorContext db, int id) =>
                db.Venda.Where(a => a.VendaId == id).AsNoTracking());

        public BlazorContext(DbContextOptions options) : base(options)
        {
            //Interlocked.Increment(ref InstanceCount);
        }

        /// <summary>
        /// 02 - DbSet
        /// </summary>

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
        public virtual DbSet<WeatherForecast> WeatherForecast { get; set; }
        public virtual DbSet<Venda> Venda { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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
            new WeatherForecastConfiguration(modelBuilder.Entity<WeatherForecast>());
            new VendaConfiguration(modelBuilder.Entity<Venda>());
        }


        /// <summary>
        /// 03 - Methods
        /// </summary>
        /// <returns></returns>

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

        public async Task<List<WeatherForecast>> GetAllWeatherForecastAsync() => 
            _queryGetAllWeatherForecast(this).ToList();

        public async Task<List<WeatherForecast>> GetWeatherForecastAsync(int id) => 
            _queryGetWeatherForecast(this, id).ToList();

        /// <summary>
        /// Venda
        /// </summary>
        /// <returns></returns>
        public async Task<List<Venda>> GetAllVendaAsync() =>
            _queryGetAllVenda(this).ToList();

        public async Task<List<Venda>> GetVendaAsync(int id) =>
            _queryGetVenda(this, id).ToList();

    }
}