using MusicDirectoryAPI.Models.Tracks;
using MusicDirectoryAPI.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicDirectoryAPI.Models.Albums
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Version { get; set; }
        public string ReleaseData { get; set; }
        public string ProviderId { get; set; }
        public UserExtension Provider { get; set; }
        public ICollection<Track> Tracks { get; set; }
    }
}
