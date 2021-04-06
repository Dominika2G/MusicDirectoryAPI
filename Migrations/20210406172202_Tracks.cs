using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicDirectoryAPI.Migrations
{
    public partial class Tracks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "TrackId", "AlbumId", "Duration", "ReleaseData", "Title", "TrackAuthor" },
                values: new object[,]
                {
                    { 1, 1, "2:21", "Czerwiec 1991", "Mój Dom", "K. Płucisz" },
                    { 24, 4, "4:15", "Wrzesień 2004", "Souvenir", "Ania Dąbrowska" },
                    { 23, 4, "5:36", "Wrzesień 2004", "Inna", "Ania Dąbrowska" },
                    { 22, 4, "2:59", "Czerwice 2004", "Charlie, Charlie", "Ania Dąbrowska" },
                    { 21, 4, "4:18", "Kwiecień 2004", "Glory", "Ania Dąbrowska" },
                    { 20, 4, "2:59", "Styczeń 2004", "Tego Chciałam", "Ania Dąbrowska" },
                    { 19, 3, "3:48", "Maj 1971", "Kwiaty we włosach", "Krzysztof Klenczon" },
                    { 18, 3, "4:20", "Maj 1971", "Nie licz dni", "Krzysztof Klenczon" },
                    { 17, 3, "3:30", "Maj 1971", "Bialy krzyż", "Krzysztof Klenczon" },
                    { 16, 3, "2:59", "Maj 1971", "Bierz życię jakie jest", "Krzysztof Klenczon" },
                    { 15, 3, "2:57", "Maj 1971", "10 w skali Beauforta", "Krzysztof Klenczon" },
                    { 14, 2, "3:20", "Kwiecień 1993", "Sen", "K. Płucisz" },
                    { 13, 2, "1:25", "Kwiecień 1993", "Twój cały świat", "Ira" },
                    { 12, 2, "5:15", "Kwiecień 1993", "Wiara", "Ira" },
                    { 11, 2, "4:40", "Kwiecień 1993", "Wyznanie", "Ira" },
                    { 10, 2, "4:58", "Kwiecień 1993", "Hey Joe", "K.Płucisz" },
                    { 9, 2, "4:47", "Kwiecień 1993", "Deszcz", "A. Gadowski" },
                    { 8, 2, "3:57", "Kwiecień 1993", "Nie zatrzymam się", "Ira" },
                    { 7, 2, "2:21", "Kwiecień 1993", "Mój Dom", "K. Płucisz" },
                    { 6, 1, "3:20", "Czerwiec 1991", "Sen", "K. Płucisz" },
                    { 5, 1, "5:15", "Czerwiec 1991", "Wiara", "Ira" },
                    { 4, 1, "4:48", "Czerwiec 1991", "Deszcz", "A. Gadowski" },
                    { 3, 1, "4:17", "Czerwiec 1991", "Kalifornia", "Ira" },
                    { 2, 1, "3:57", "Czerwiec 1991", "Nie zatrzymam się", "Ira" },
                    { 25, 4, "4:00", "Wrzesień 2004", "Gangsta", "Ania Dąbrowska" },
                    { 26, 4, "3:28", "Wrzesień 2004", "Pamietać chcę", "Ania Dąbrowska" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 26);
        }
    }
}
