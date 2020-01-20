﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Blazor.Domain.Converters;
using Blazor.Domain.Entities;
using Newtonsoft.Json;

namespace Blazor.Domain.ApiModels
{
    public class PlaylistApiModel : IConvertModel<PlaylistApiModel, Playlist>
    {

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int PlaylistId { get; set; }

        public string Name { get; set; }
        [NotMapped]
        [JsonIgnore]
        public IList<TrackApiModel> Tracks { get; set; }
        [NotMapped]
        [JsonIgnore]
        public IList<PlaylistTrackApiModel> PlaylistTracks { get; set; }
        
        public Playlist Convert() => new Playlist
        {
            PlaylistId = PlaylistId,
            Name = Name
        };
    }
}