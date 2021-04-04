using Microsoft.AspNetCore.Identity;
using MusicDirectoryAPI.Models.Albums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicDirectoryAPI.Models.Users
{
    public class UserExtension: IdentityUser
    {
        public ICollection<Album> Albums { get; set; }
    }
}
