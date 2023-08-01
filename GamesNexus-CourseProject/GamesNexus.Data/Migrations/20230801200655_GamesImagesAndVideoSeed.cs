using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesNexus.Data.Migrations
{
    public partial class GamesImagesAndVideoSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GamesImages",
                columns: new[] { "Id", "GameId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, 1, "https://media.wired.co.uk/photos/606da9336ab54fce4fbb245f/master/w_1280,c_limit/lol_1.jpg" },
                    { 2, 1, "https://i.pinimg.com/564x/c5/6c/77/c56c774ee09e3e16bf12460dea765109.jpg" },
                    { 3, 2, "https://cdn.mobygames.com/covers/7240915-spyro-reignited-trilogy-xbox-one-front-cover.jpg" }
                });

            migrationBuilder.InsertData(
                table: "GamesVideos",
                columns: new[] { "Id", "GameId", "VideoUrl" },
                values: new object[,]
                {
                    { 1, 1, "https://www.leagueoflegends.com/static/hero-0632cbf2872c5cc0dffa93d2ae8a29e8.webm" },
                    { 2, 2, "https://cdn.akamai.steamstatic.com/steam/apps/256752581/movie480.webm?t=1560272971" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GamesImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GamesImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GamesImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GamesVideos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GamesVideos",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
