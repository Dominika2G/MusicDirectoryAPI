using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MusicDirectoryAPI.Models.Albums;
using MusicDirectoryAPI.Models.Tracks;
using MusicDirectoryAPI.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicDirectoryAPI.DAL.Configurations
{
    public static class SeedingData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserExtension>().HasData(
                new UserExtension
                {
                    Id = "7e635286-9611-4daa-944d-491cab5caa61",
                    UserName = "Akar",
                    NormalizedUserName = "AKAR",
                    Email = "Akar@gmail.com",
                    NormalizedEmail = "AKAR@GMAIL.COM",
                    PasswordHash = "AQAAAAEAACcQAAAAEEciiGUefUrhEynppv+2l6uVeBQV7J+ejYbpuFtvJfFkiQq6Y4kLH7ODEWMvWPBcjQ==",
                    SecurityStamp = "GK76NC7BDNYBR5SIKRUVULW3MQ2PCFKR",
                    ConcurrencyStamp = "05cdbdcc-902d-4ebf-bf94-a7933f3c3b3b"

                },
                new UserExtension
                {
                    Id = "8877e57f-5568-4d41-a51c-f3d24e909484",
                    UserName = "BMGPoland",
                    NormalizedUserName = "BMGPOLAND",
                    Email = "BMGPoland@gmail.com",
                    NormalizedEmail = "BMGPOLAND@GMAIL.COM",
                    PasswordHash = "AQAAAAEAACcQAAAAEJx4bIM8lZujSXwUkB8YYU8OAc1/nBDKQSqwnTFCo9s/2Qg2aNNyuqnVjieDg6697Q==",
                    SecurityStamp = "T2VQWGDP4HSA6VEWQISPLXVMSIV4SJVS",
                    ConcurrencyStamp = "7db1a689-9b13-433a-9ea0-da1be6db2f22"
                }
                );

                 modelBuilder.Entity<Album>().HasData(
                     new Album { AlbumId = 1, Author = "IRA", Title = "IRA Live", Version = "1", ReleaseData = "1993", ProviderId = "7e635286-9611-4daa-944d-491cab5caa61" },
                     new Album { AlbumId = 2, Author = "IRA", Title = "IRA Live", Version = "2", ReleaseData = "1995", ProviderId = "7e635286-9611-4daa-944d-491cab5caa61" },
                     new Album { AlbumId = 3, Author = "Krzysztof Klenczon", Title = "10 w skali Beauforta", Version = "1", ReleaseData = "1995", ProviderId = "7e635286-9611-4daa-944d-491cab5caa61" },
                     new Album { AlbumId = 4, Author = "Ania Dąbrowska", Title = "Samotnosć po zmierzchu", Version = "1", ReleaseData = "2004", ProviderId = "8877e57f-5568-4d41-a51c-f3d24e909484" },
                     new Album { AlbumId = 5, Author = "Monika Brodka", Title = "Album", Version = "1", ReleaseData = "2004", ProviderId = "8877e57f-5568-4d41-a51c-f3d24e909484" }
                     );
                modelBuilder.Entity<Track>().HasData(
                     new Track { TrackId = 1, TrackAuthor = "K. Płucisz", Title = "Mój Dom", ReleaseData = "Czerwiec 1991", Duration = "2:21", AlbumId = 1 },
                     new Track { TrackId = 2, TrackAuthor = "Ira", Title = "Nie zatrzymam się", ReleaseData = "Czerwiec 1991", Duration = "3:57", AlbumId = 1 },
                     new Track { TrackId = 3, TrackAuthor = "Ira", Title = "Kalifornia", ReleaseData = "Czerwiec 1991", Duration = "4:17", AlbumId = 1 },
                     new Track { TrackId = 4, TrackAuthor = "A. Gadowski", Title = "Deszcz", ReleaseData = "Czerwiec 1991", Duration = "4:48", AlbumId = 1 },
                     new Track { TrackId = 5, TrackAuthor = "Ira", Title = "Wiara", ReleaseData = "Czerwiec 1991", Duration = "5:15", AlbumId = 1 },
                     new Track { TrackId = 6, TrackAuthor = "K. Płucisz", Title = "Sen", ReleaseData = "Czerwiec 1991", Duration = "3:20", AlbumId = 1 },
                     new Track { TrackId = 7, TrackAuthor = "K. Płucisz", Title = "Mój Dom", ReleaseData = "Kwiecień 1993", Duration = "2:21", AlbumId = 2 },
                     new Track { TrackId = 8, TrackAuthor = "Ira", Title = "Nie zatrzymam się", ReleaseData = "Kwiecień 1993", Duration = "3:57", AlbumId = 2 },
                     new Track { TrackId = 9, TrackAuthor = "A. Gadowski", Title = "Deszcz", ReleaseData = "Kwiecień 1993", Duration = "4:47", AlbumId = 2 },
                     new Track { TrackId = 10, TrackAuthor = "K.Płucisz", Title = "Hey Joe", ReleaseData = "Kwiecień 1993", Duration = "4:58", AlbumId = 2 },
                     new Track { TrackId = 11, TrackAuthor = "Ira", Title = "Wyznanie", ReleaseData = "Kwiecień 1993", Duration = "4:40", AlbumId = 2 },
                     new Track { TrackId = 12, TrackAuthor = "Ira", Title = "Wiara", ReleaseData = "Kwiecień 1993", Duration = "5:15", AlbumId = 2 },
                     new Track { TrackId = 13, TrackAuthor = "Ira", Title = "Twój cały świat", ReleaseData = "Kwiecień 1993", Duration = "1:25", AlbumId = 2 },
                     new Track { TrackId = 14, TrackAuthor = "K. Płucisz", Title = "Sen", ReleaseData = "Kwiecień 1993", Duration = "3:20", AlbumId = 2 },
                     new Track { TrackId = 15, TrackAuthor = "Krzysztof Klenczon", Title = "10 w skali Beauforta", ReleaseData = "Maj 1971", Duration = "2:57", AlbumId = 3 },
                     new Track { TrackId = 16, TrackAuthor = "Krzysztof Klenczon", Title = "Bierz życię jakie jest", ReleaseData = "Maj 1971", Duration = "2:59", AlbumId = 3 },
                     new Track { TrackId = 17, TrackAuthor = "Krzysztof Klenczon", Title = "Bialy krzyż", ReleaseData = "Maj 1971", Duration = "3:30", AlbumId = 3 },
                     new Track { TrackId = 18, TrackAuthor = "Krzysztof Klenczon", Title = "Nie licz dni", ReleaseData = "Maj 1971", Duration = "4:20", AlbumId = 3 },
                     new Track { TrackId = 19, TrackAuthor = "Krzysztof Klenczon", Title = "Kwiaty we włosach", ReleaseData = "Maj 1971", Duration = "3:48", AlbumId = 3 },
                     new Track { TrackId = 20, TrackAuthor = "Ania Dąbrowska", Title = "Tego Chciałam", ReleaseData = "Styczeń 2004", Duration = "2:59", AlbumId = 4 },
                     new Track { TrackId = 21, TrackAuthor = "Ania Dąbrowska", Title = "Glory", ReleaseData = "Kwiecień 2004", Duration = "4:18", AlbumId = 4 },
                     new Track { TrackId = 22, TrackAuthor = "Ania Dąbrowska", Title = "Charlie, Charlie", ReleaseData = "Czerwice 2004", Duration = "2:59", AlbumId = 4 },
                     new Track { TrackId = 23, TrackAuthor = "Ania Dąbrowska", Title = "Inna", ReleaseData = "Wrzesień 2004", Duration = "5:36", AlbumId = 4 },
                     new Track { TrackId = 24, TrackAuthor = "Ania Dąbrowska", Title = "Souvenir", ReleaseData = "Wrzesień 2004", Duration = "4:15", AlbumId = 4 },
                     new Track { TrackId = 25, TrackAuthor = "Ania Dąbrowska", Title = "Gangsta", ReleaseData = "Wrzesień 2004", Duration = "4:00", AlbumId = 4 },
                     new Track { TrackId = 26, TrackAuthor = "Ania Dąbrowska", Title = "Pamietać chcę", ReleaseData = "Wrzesień 2004", Duration = "3:28", AlbumId = 4 }
                     );




        }
    }
}
