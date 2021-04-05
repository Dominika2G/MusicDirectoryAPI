using MusicDirectoryAPI.Models.Albums;
using System.ComponentModel.DataAnnotations;

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
