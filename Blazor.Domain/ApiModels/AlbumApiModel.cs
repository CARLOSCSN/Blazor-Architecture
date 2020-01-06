using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Blazor.Domain.Converters;
using Blazor.Domain.Entities;
using Newtonsoft.Json;

namespace Blazor.Domain.ApiModels
{
    public class AlbumApiModel : IConvertModel<AlbumApiModel, Album>
    {

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int AlbumId { get; set; }

        public string Title { get; set; }

        public int ArtistId { get; set; }
        
        [NotMapped]
        [JsonIgnore]
        public string ArtistName { get; set; }

        [NotMapped]
        [JsonIgnore]
        public ArtistApiModel Artist { get; set; }
        
        [NotMapped]
        [JsonIgnore]
        public IList<TrackApiModel> Tracks { get; set; }
            
        public Album Convert() => new Album
        {
            AlbumId = AlbumId,
            ArtistId = ArtistId,
            Title = Title
        };
    }
}