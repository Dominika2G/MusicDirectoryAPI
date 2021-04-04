using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicDirectoryAPI.DAL.Configurations;
using MusicDirectoryAPI.Models.Albums;
using MusicDirectoryAPI.Models.Tracks;
using MusicDirectoryAPI.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicDirectoryAPI.DAL
{
    public class DatabaseContext: IdentityDbContext
    {
        public DbSet<UserExtension> Users { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }

        #region DatabaseConstructor
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        #endregion

        #region OnModelCreatring
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AlbumConfiguration());
        }
        #endregion
    }
}
