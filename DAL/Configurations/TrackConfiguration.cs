using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicDirectoryAPI.Models.Tracks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicDirectoryAPI.DAL.Configurations
{
    public class TrackConfiguration: IEntityTypeConfiguration<Track>
    {
        public void Configure(EntityTypeBuilder<Track> builder)
        {
            builder
                .HasOne(a => a.Album)
                .WithMany(t => t.Tracks)
                .HasForeignKey(a => a.AlbumId);
        }
    }
}
