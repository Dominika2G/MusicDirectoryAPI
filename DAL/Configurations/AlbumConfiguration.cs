using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicDirectoryAPI.Models.Albums;

namespace MusicDirectoryAPI.DAL.Configurations
{
    public class AlbumConfiguration: IEntityTypeConfiguration<Album>
    {
        #region Configure
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder
                .HasOne(p => p.Provider)
                .WithMany(a => a.Albums)
                .HasForeignKey(p => p.ProviderId);
        }
        #endregion
    }
}
