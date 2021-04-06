using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicDirectoryAPI.Migrations
{
    public partial class Albums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7e635286-9611-4daa-944d-491cab5caa61", 0, "05cdbdcc-902d-4ebf-bf94-a7933f3c3b3b", "UserExtension", "Akar@gmail.com", false, false, null, "AKAR@GMAIL.COM", "AKAR", "AQAAAAEAACcQAAAAEEciiGUefUrhEynppv+2l6uVeBQV7J+ejYbpuFtvJfFkiQq6Y4kLH7ODEWMvWPBcjQ==", null, false, "GK76NC7BDNYBR5SIKRUVULW3MQ2PCFKR", false, "Akar" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8877e57f-5568-4d41-a51c-f3d24e909484", 0, "7db1a689-9b13-433a-9ea0-da1be6db2f22", "UserExtension", "BMGPoland@gmail.com", false, false, null, "BMGPOLAND@GMAIL.COM", "BMGPOLAND", "AQAAAAEAACcQAAAAEJx4bIM8lZujSXwUkB8YYU8OAc1/nBDKQSqwnTFCo9s/2Qg2aNNyuqnVjieDg6697Q==", null, false, "T2VQWGDP4HSA6VEWQISPLXVMSIV4SJVS", false, "BMGPoland" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "Author", "ProviderId", "ReleaseData", "Title", "Version" },
                values: new object[,]
                {
                    { 1, "IRA", "7e635286-9611-4daa-944d-491cab5caa61", "1993", "IRA Live", "1" },
                    { 2, "IRA", "7e635286-9611-4daa-944d-491cab5caa61", "1995", "IRA Live", "2" },
                    { 3, "Krzysztof Klenczon", "7e635286-9611-4daa-944d-491cab5caa61", "1995", "10 w skali Beauforta", "1" },
                    { 4, "Ania Dąbrowska", "8877e57f-5568-4d41-a51c-f3d24e909484", "2004", "Samotnosć po zmierzchu", "1" },
                    { 5, "Monika Brodka", "8877e57f-5568-4d41-a51c-f3d24e909484", "2004", "Album", "1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e635286-9611-4daa-944d-491cab5caa61");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8877e57f-5568-4d41-a51c-f3d24e909484");
        }
    }
}
