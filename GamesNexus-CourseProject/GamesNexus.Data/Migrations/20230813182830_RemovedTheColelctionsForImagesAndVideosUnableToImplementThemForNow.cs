using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesNexus.Data.Migrations
{
    public partial class RemovedTheColelctionsForImagesAndVideosUnableToImplementThemForNow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GamesImages");

            migrationBuilder.DropTable(
                name: "GamesVideos");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 401, DateTimeKind.Utc).AddTicks(1037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(4506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(9541),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(2855));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(9365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(2694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(8380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.AddColumn<string>(
                name: "Image1URL",
                table: "Games",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image2URL",
                table: "Games",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image3URL",
                table: "Games",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoURL",
                table: "Games",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(7399),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 503, DateTimeKind.Utc).AddTicks(9991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(7209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 503, DateTimeKind.Utc).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Image1URL", "Image2URL", "ReleaseDate", "VideoURL" },
                values: new object[] { "https://media.wired.co.uk/photos/606da9336ab54fce4fbb245f/master/w_1280,c_limit/lol_1.jpg", "https://i.pinimg.com/564x/c5/6c/77/c56c774ee09e3e16bf12460dea765109.jpg", new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(8718), "https://www.leagueoflegends.com/static/hero-0632cbf2872c5cc0dffa93d2ae8a29e8.webm" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Image1URL", "ReleaseDate", "VideoURL" },
                values: new object[] { "https://cdn.mobygames.com/covers/7240915-spyro-reignited-trilogy-xbox-one-front-cover.jpg", new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(8731), "https://cdn.akamai.steamstatic.com/steam/apps/256752581/movie480.webm?t=1560272971" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Image1URL", "Image2URL", "ReleaseDate", "VideoURL" },
                values: new object[] { "https://fanspace.gg/wp-content/uploads/2022/12/csgo-1-1024x576.jpg", "https://estnn.com/wp-content/uploads/2021/04/csgoft2.jpg.webp", new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(8734), "https://cdn.cloudflare.steamstatic.com/steam/apps/81958/movie480.webm?t=1554409259" });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 401, DateTimeKind.Utc).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 401, DateTimeKind.Utc).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 401, DateTimeKind.Utc).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 401, DateTimeKind.Utc).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 401, DateTimeKind.Utc).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 401, DateTimeKind.Utc).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "PostedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 401, DateTimeKind.Utc).AddTicks(1153));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1URL",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Image2URL",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Image3URL",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "VideoURL",
                table: "Games");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(4506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 401, DateTimeKind.Utc).AddTicks(1037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(2855),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(9541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(2694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(9365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(1016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 503, DateTimeKind.Utc).AddTicks(9991),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(7399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 503, DateTimeKind.Utc).AddTicks(9732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.CreateTable(
                name: "GamesImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<long>(type: "bigint", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamesImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GamesImages_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GamesVideos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<long>(type: "bigint", nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamesVideos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GamesVideos_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(1811));

            migrationBuilder.InsertData(
                table: "GamesImages",
                columns: new[] { "Id", "GameId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, 1L, "https://media.wired.co.uk/photos/606da9336ab54fce4fbb245f/master/w_1280,c_limit/lol_1.jpg" },
                    { 2, 1L, "https://i.pinimg.com/564x/c5/6c/77/c56c774ee09e3e16bf12460dea765109.jpg" },
                    { 3, 2L, "https://cdn.mobygames.com/covers/7240915-spyro-reignited-trilogy-xbox-one-front-cover.jpg" },
                    { 4, 3L, "https://fanspace.gg/wp-content/uploads/2022/12/csgo-1-1024x576.jpg" },
                    { 5, 3L, "https://estnn.com/wp-content/uploads/2021/04/csgoft2.jpg.webp" }
                });

            migrationBuilder.InsertData(
                table: "GamesVideos",
                columns: new[] { "Id", "GameId", "VideoUrl" },
                values: new object[,]
                {
                    { 1, 1L, "https://www.leagueoflegends.com/static/hero-0632cbf2872c5cc0dffa93d2ae8a29e8.webm" },
                    { 2, 2L, "https://cdn.akamai.steamstatic.com/steam/apps/256752581/movie480.webm?t=1560272971" },
                    { 3, 3L, "https://cdn.cloudflare.steamstatic.com/steam/apps/81958/movie480.webm?t=1554409259" }
                });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedOn",
                value: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedOn",
                value: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedOn",
                value: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostedOn",
                value: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "PostedOn",
                value: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.CreateIndex(
                name: "IX_GamesImages_GameId",
                table: "GamesImages",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GamesVideos_GameId",
                table: "GamesVideos",
                column: "GameId");
        }
    }
}
