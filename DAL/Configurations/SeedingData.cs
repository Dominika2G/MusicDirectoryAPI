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
                    Id = "1",
                    UserName = "Akar",
                    PasswordHash = "AQAAAAEAACcQAAAAEAjQyTJhYiw5gN+kf2SdGEBHXb7bWqrAHMjQ5Vwcwcs4/Gkdt15YhW0Vz+CIViafRw==",
                    SecurityStamp = "MAYDUL6ZVPX7JU7HY3SRFZNQKVN76YQ4",
                    ConcurrencyStamp = "6d4709e2-e133-4450-b3cc-8af8a85ff080",
                    Email = "Akar@gmail.com"
                },
                new UserExtension
                {
                    Id = "2",
                    UserName = "BMGPoland",
                    PasswordHash = "AQAAAAEAACcQAAAAEB+LKiXUSINk770orH8F5k7BSRVe7FJDBmjz2bBCsGemnzThyWW+U94Ygi+9vD2cEw==",
                    SecurityStamp = "YEIX5R3WZRR3CXV3X6Y6L2S7JLJNZJMY",
                    ConcurrencyStamp = "0c6805d9-280a-41ed-a9db-a421bffdd4cd",
                    Email = "BMGPoland@gmail.com"
                }
                );


            modelBuilder.Entity<Album>().HasData(
                new Album { Author = "IRA", Title = "IRA Live", Version = "1", ReleaseData = "1993", ProviderId = "1" },
                new Album { Author = "IRA", Title = "IRA Live", Version = "2", ReleaseData = "1995", ProviderId = "1" },
                new Album { Author = "Krzysztof Klenczon", Title = "10 w skali Beauforta", Version = "1", ReleaseData = "1995", ProviderId = "1" },
                new Album { Author = "Ania Dąbrowska", Title = "Samotnosć po zmierzchu", Version = "1", ReleaseData = "2004", ProviderId = "2" },
                new Album { Author = "Monika Brodka", Title = "Album", Version = "1", ReleaseData = "2004", ProviderId = "2" }
                );

            modelBuilder.Entity<Track>().HasData(
                new Track { TrackAuthor = "K. Płucisz", Title = "Mój Dom", ReleaseData = "Czerwiec 1991", Duration = "2:21", AlbumId = 1 },
                new Track { TrackAuthor = "Ira", Title = "Nie zatrzymam się", ReleaseData = "Czerwiec 1991", Duration = "3:57", AlbumId = 1 },
                new Track { TrackAuthor = "Ira", Title = "Kalifornia", ReleaseData = "Czerwiec 1991", Duration = "4:17", AlbumId = 1 },
                new Track { TrackAuthor = "A. Gadowski", Title = "Deszcz", ReleaseData = "Czerwiec 1991", Duration = "4:48", AlbumId = 1 },
                new Track { TrackAuthor = "Ira", Title = "Wiara", ReleaseData = "Czerwiec 1991", Duration = "5:15", AlbumId = 1 },
                new Track { TrackAuthor = "K. Płucisz", Title = "Sen", ReleaseData = "Czerwiec 1991", Duration = "3:20", AlbumId = 1 },
                new Track { TrackAuthor = "K. Płucisz", Title = "Mój Dom", ReleaseData = "Kwiecień 1993", Duration = "2:21", AlbumId = 2 },
                new Track { TrackAuthor = "Ira", Title = "Nie zatrzymam się", ReleaseData = "Kwiecień 1993", Duration = "3:57", AlbumId = 2 },
                new Track { TrackAuthor = "A. Gadowski", Title = "Deszcz", ReleaseData = "Kwiecień 1993", Duration = "4:47", AlbumId = 2 },
                new Track { TrackAuthor = "K.Płucisz", Title = "Hey Joe", ReleaseData = "Kwiecień 1993", Duration = "4:58", AlbumId = 2 },
                new Track { TrackAuthor = "Ira", Title = "Wyznanie", ReleaseData = "Kwiecień 1993", Duration = "4:40", AlbumId = 2 },
                new Track { TrackAuthor = "Ira", Title = "Wiara", ReleaseData = "Kwiecień 1993", Duration = "5:15", AlbumId = 2 },
                new Track { TrackAuthor = "Ira", Title = "Twój cały świat", ReleaseData = "Kwiecień 1993", Duration = "1:25", AlbumId = 2 },
                new Track { TrackAuthor = "K. Płucisz", Title = "Sen", ReleaseData = "Kwiecień 1993", Duration = "3:20", AlbumId = 2 },
                new Track { TrackAuthor = "Krzysztof Klenczon", Title = "10 w skali Beauforta", ReleaseData = "Maj 1971", Duration = "2:57", AlbumId = 3 },
                new Track { TrackAuthor = "Krzysztof Klenczon", Title = "Bierz życię jakie jest", ReleaseData = "Maj 1971", Duration = "2:59", AlbumId = 3 },
                new Track { TrackAuthor = "Krzysztof Klenczon", Title = "Bialy krzyż", ReleaseData = "Maj 1971", Duration = "3:30", AlbumId = 3 },
                new Track { TrackAuthor = "Krzysztof Klenczon", Title = "Nie licz dni", ReleaseData = "Maj 1971", Duration = "4:20", AlbumId = 3 },
                new Track { TrackAuthor = "Krzysztof Klenczon", Title = "Kwiaty we włosach", ReleaseData = "Maj 1971", Duration = "3:48", AlbumId = 3 },
                new Track { TrackAuthor = "Ania Dąbrowska", Title = "Tego Chciałam", ReleaseData = "Styczeń 2004", Duration = "2:59", AlbumId = 4 },
                new Track { TrackAuthor = "Ania Dąbrowska", Title = "Glory", ReleaseData = "Kwiecień 2004", Duration = "4:18", AlbumId = 4 },
                new Track { TrackAuthor = "Ania Dąbrowska", Title = "Charlie, Charlie", ReleaseData = "Czerwice 2004", Duration = "2:59", AlbumId = 4 },
                new Track { TrackAuthor = "Ania Dąbrowska", Title = "Inna", ReleaseData = "Wrzesień 2004", Duration = "5:36", AlbumId = 4 },
                new Track { TrackAuthor = "Ania Dąbrowska", Title = "Souvenir", ReleaseData = "Wrzesień 2004", Duration = "4:15", AlbumId = 4 },
                new Track { TrackAuthor = "Ania Dąbrowska", Title = "Gangsta", ReleaseData = "Wrzesień 2004", Duration = "4:00", AlbumId = 4 },
                new Track { TrackAuthor = "Ania Dąbrowska", Title = "Pamietać chcę", ReleaseData = "Wrzesień 2004", Duration = "3:28", AlbumId = 4 }
                );


        }
    }
}
