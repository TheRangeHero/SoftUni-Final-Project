using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesNexus.Data.Migrations
{
    public partial class AdditionsForSystemReqAndInitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RAM",
                table: "SystemRequirements",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "OS",
                table: "SystemRequirements",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GPU",
                table: "SystemRequirements",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPU",
                table: "SystemRequirements",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdditionalNotes",
                table: "SystemRequirements",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Single-player" },
                    { 2, "Multi-player" },
                    { 3, "LAN" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "ApplicationUserId", "Description", "Developer", "Price", "PublisherId", "ReleaseDate", "SystemRequirementId", "Title" },
                values: new object[,]
                {
                    { 1L, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras tellus nunc, porttitor vel sapien eget, ornare tristique mauris. Donec diam neque, auctor et dui non.", "Riot Games", 10.25m, new Guid("dae07e76-9f5d-4bfb-800b-c0dfb0efec5b"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), 0L, "League of Legends" },
                    { 2L, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque consectetur gravida orci in dapibus. Mauris pharetra efficitur nisi ut vehicula. Nulla dapibus faucibus gravida. Nunc a eleifend sem, at tempus ante. Nunc tincidunt laoreet nisl, at viverra mauris ultricies iaculis. Nullam dui leo, mattis eu rutrum sed, vehicula at odio.", "Insomniac Games", 55.55m, new Guid("dae07e76-9f5d-4bfb-800b-c0dfb0efec5b"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), 0L, "Spyro" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Strategy" },
                    { 3, "Adventure" },
                    { 4, "Simulation" }
                });

            migrationBuilder.InsertData(
                table: "GamesCategories",
                columns: new[] { "CategoryId", "GameId" },
                values: new object[,]
                {
                    { 2, 1L },
                    { 1, 2L }
                });

            migrationBuilder.InsertData(
                table: "GamesGenres",
                columns: new[] { "GameId", "GenreId" },
                values: new object[,]
                {
                    { 1L, 1 },
                    { 1L, 2 },
                    { 2L, 1 },
                    { 2L, 3 }
                });

            migrationBuilder.InsertData(
                table: "GamesImages",
                columns: new[] { "Id", "GameId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, 1L, "https://media.wired.co.uk/photos/606da9336ab54fce4fbb245f/master/w_1280,c_limit/lol_1.jpg" },
                    { 2, 1L, "https://i.pinimg.com/564x/c5/6c/77/c56c774ee09e3e16bf12460dea765109.jpg" },
                    { 3, 2L, "https://cdn.mobygames.com/covers/7240915-spyro-reignited-trilogy-xbox-one-front-cover.jpg" }
                });

            migrationBuilder.InsertData(
                table: "GamesVideos",
                columns: new[] { "Id", "GameId", "VideoUrl" },
                values: new object[,]
                {
                    { 1, 1L, "https://www.leagueoflegends.com/static/hero-0632cbf2872c5cc0dffa93d2ae8a29e8.webm" },
                    { 2, 2L, "https://cdn.akamai.steamstatic.com/steam/apps/256752581/movie480.webm?t=1560272971" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GamesCategories",
                keyColumns: new[] { "CategoryId", "GameId" },
                keyValues: new object[] { 2, 1L });

            migrationBuilder.DeleteData(
                table: "GamesCategories",
                keyColumns: new[] { "CategoryId", "GameId" },
                keyValues: new object[] { 1, 2L });

            migrationBuilder.DeleteData(
                table: "GamesGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 1L, 1 });

            migrationBuilder.DeleteData(
                table: "GamesGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 1L, 2 });

            migrationBuilder.DeleteData(
                table: "GamesGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 2L, 1 });

            migrationBuilder.DeleteData(
                table: "GamesGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 2L, 3 });

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

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AdditionalNotes",
                table: "SystemRequirements");

            migrationBuilder.AlterColumn<int>(
                name: "RAM",
                table: "SystemRequirements",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OS",
                table: "SystemRequirements",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GPU",
                table: "SystemRequirements",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPU",
                table: "SystemRequirements",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
