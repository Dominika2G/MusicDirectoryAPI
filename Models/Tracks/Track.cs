using MusicDirectoryAPI.Models.Albums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicDirectoryAPI.Models.Tracks
{
    public class Track
    {
        [Key]
        public int TrackId { get; set; }
        public string TrackAuthor { get; set; }
        public string Title { get; set; }
        public string ReleaseData { get; set; }
        public string Duration { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}
