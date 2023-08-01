using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesNexus.Data.Migrations
{
    public partial class GamesSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "ApplicationUserId", "Description", "Developer", "OrderId", "Price", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { 1, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras tellus nunc, porttitor vel sapien eget, ornare tristique mauris. Donec diam neque, auctor et dui non.", "Riot Games", null, 10.25m, new Guid("a9ac2bf7-c3e8-4597-841b-21a6ce1b766b"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "League of Legends" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "ApplicationUserId", "Description", "Developer", "OrderId", "Price", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque consectetur gravida orci in dapibus. Mauris pharetra efficitur nisi ut vehicula. Nulla dapibus faucibus gravida. Nunc a eleifend sem, at tempus ante. Nunc tincidunt laoreet nisl, at viverra mauris ultricies iaculis. Nullam dui leo, mattis eu rutrum sed, vehicula at odio.", "Insomniac Games", null, 55.55m, new Guid("a9ac2bf7-c3e8-4597-841b-21a6ce1b766b"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Spyro" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
