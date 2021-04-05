using Microsoft.AspNetCore.Identity;
using MusicDirectoryAPI.Models.Albums;
using System.Collections.Generic;

namespace MusicDirectoryAPI.Models.Users
{
    public class UserExtension: IdentityUser
    {
        public ICollection<Album> Albums { get; set; }
    }
}
