using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesNexus.Data.Migrations
{
    public partial class SystemRequirementSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SystemRequirements",
                columns: new[] { "Id", "AdditionalNotes", "CPU", "GPU", "GameId", "OS", "RAM", "Storage" },
                values: new object[] { 1L, "SSD recommended, 60 FPS, 1920x1080 in ultra", "AMD Ryzen 3 1200 or Intel Core i5-2500", "4 GB VRAM, AMD Radeon R9 380 or NVIDIA GeForce GTX 960 DirectX: Version 12", 1L, "Windows 10 (20H1 version or newer, 64-bit versions)", "8 GB RAM", "90 GB available space" });

            migrationBuilder.InsertData(
                table: "SystemRequirements",
                columns: new[] { "Id", "AdditionalNotes", "CPU", "GPU", "GameId", "OS", "RAM", "Storage" },
                values: new object[] { 2L, null, "Intel Core i5-2500K | AMD FX-8350", "NVIDIA GeForce GTX 960 (2 GB) | AMD Radeon RX 480", 2L, "Windows 7", "8 GB RAM", "40 GB available space" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SystemRequirements",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "SystemRequirements",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
