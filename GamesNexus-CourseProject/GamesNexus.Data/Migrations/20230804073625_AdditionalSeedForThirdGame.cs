using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesNexus.Data.Migrations
{
    public partial class AdditionalSeedForThirdGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 4, 7, 36, 24, 400, DateTimeKind.Utc).AddTicks(2038),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 20, 46, 58, 204, DateTimeKind.Utc).AddTicks(9208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 4, 7, 36, 24, 399, DateTimeKind.Utc).AddTicks(5399),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 20, 46, 58, 204, DateTimeKind.Utc).AddTicks(7728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 4, 7, 36, 24, 399, DateTimeKind.Utc).AddTicks(4737),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 20, 46, 58, 204, DateTimeKind.Utc).AddTicks(7549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 4, 7, 36, 24, 396, DateTimeKind.Utc).AddTicks(9865),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 20, 46, 58, 204, DateTimeKind.Utc).AddTicks(1837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 4, 7, 36, 24, 396, DateTimeKind.Utc).AddTicks(6078),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 20, 46, 58, 203, DateTimeKind.Utc).AddTicks(9282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 4, 7, 36, 24, 396, DateTimeKind.Utc).AddTicks(5568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 20, 46, 58, 203, DateTimeKind.Utc).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 4, 7, 36, 24, 398, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 4, 7, 36, 24, 398, DateTimeKind.Utc).AddTicks(8788));

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "ApplicationUserId", "Description", "Developer", "Price", "PublisherId", "ReleaseDate", "SystemRequirementId", "Title" },
                values: new object[] { 3L, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla laoreet sagittis quam, et sollicitudin nulla.", "Valve Corporation, Hidden Path Entertainment", 20m, new Guid("dae07e76-9f5d-4bfb-800b-c0dfb0efec5b"), new DateTime(2023, 8, 4, 7, 36, 24, 398, DateTimeKind.Utc).AddTicks(8793), 0L, "CS:GO" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Shooter" });

            migrationBuilder.InsertData(
                table: "GamesCategories",
                columns: new[] { "CategoryId", "GameId" },
                values: new object[] { 2, 3L });

            migrationBuilder.InsertData(
                table: "GamesGenres",
                columns: new[] { "GameId", "GenreId" },
                values: new object[,]
                {
                    { 3L, 1 },
                    { 3L, 5 }
                });

            migrationBuilder.InsertData(
                table: "GamesImages",
                columns: new[] { "Id", "GameId", "ImageUrl" },
                values: new object[,]
                {
                    { 4, 3L, "https://fanspace.gg/wp-content/uploads/2022/12/csgo-1-1024x576.jpg" },
                    { 5, 3L, "https://estnn.com/wp-content/uploads/2021/04/csgoft2.jpg.webp" }
                });

            migrationBuilder.InsertData(
                table: "GamesVideos",
                columns: new[] { "Id", "GameId", "VideoUrl" },
                values: new object[] { 3, 3L, "https://cdn.cloudflare.steamstatic.com/steam/apps/81958/movie480.webm?t=1554409259" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GamesCategories",
                keyColumns: new[] { "CategoryId", "GameId" },
                keyValues: new object[] { 2, 3L });

            migrationBuilder.DeleteData(
                table: "GamesGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 3L, 1 });

            migrationBuilder.DeleteData(
                table: "GamesGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 3L, 5 });

            migrationBuilder.DeleteData(
                table: "GamesImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GamesImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GamesVideos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 20, 46, 58, 204, DateTimeKind.Utc).AddTicks(9208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 4, 7, 36, 24, 400, DateTimeKind.Utc).AddTicks(2038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 20, 46, 58, 204, DateTimeKind.Utc).AddTicks(7728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 4, 7, 36, 24, 399, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 20, 46, 58, 204, DateTimeKind.Utc).AddTicks(7549),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 4, 7, 36, 24, 399, DateTimeKind.Utc).AddTicks(4737));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 20, 46, 58, 204, DateTimeKind.Utc).AddTicks(1837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 4, 7, 36, 24, 396, DateTimeKind.Utc).AddTicks(9865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 20, 46, 58, 203, DateTimeKind.Utc).AddTicks(9282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 4, 7, 36, 24, 396, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 20, 46, 58, 203, DateTimeKind.Utc).AddTicks(9115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 4, 7, 36, 24, 396, DateTimeKind.Utc).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 3, 20, 46, 58, 204, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 3, 20, 46, 58, 204, DateTimeKind.Utc).AddTicks(6623));
        }
    }
}
