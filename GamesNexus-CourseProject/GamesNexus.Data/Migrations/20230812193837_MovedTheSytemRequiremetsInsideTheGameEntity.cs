using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesNexus.Data.Migrations
{
    public partial class MovedTheSytemRequiremetsInsideTheGameEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SystemRequirements");

            migrationBuilder.DropColumn(
                name: "SystemRequirementId",
                table: "Games");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(4506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 978, DateTimeKind.Utc).AddTicks(1389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(2855),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(9774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(2694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(9554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(1016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(4477));

            migrationBuilder.AddColumn<string>(
                name: "AdditionalNotes",
                table: "Games",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CPU",
                table: "Games",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GPU",
                table: "Games",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OS",
                table: "Games",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RAM",
                table: "Games",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Storage",
                table: "Games",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 503, DateTimeKind.Utc).AddTicks(9991),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 503, DateTimeKind.Utc).AddTicks(9732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AdditionalNotes", "CPU", "GPU", "OS", "RAM", "ReleaseDate", "Storage" },
                values: new object[] { "SSD recommended, 60 FPS, 1920x1080 in ultra", "AMD Ryzen 3 1200 or Intel Core i5-2500", "4 GB VRAM, AMD Radeon R9 380 or NVIDIA GeForce GTX 960 DirectX: Version 12", "Windows 10 (20H1 version or newer, 64-bit versions)", "8 GB RAM", new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(1776), "90 GB available space" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CPU", "GPU", "OS", "RAM", "ReleaseDate", "Storage" },
                values: new object[] { "Intel Core i5-2500K | AMD FX-8350", "NVIDIA GeForce GTX 960 (2 GB) | AMD Radeon RX 480", "Windows 7", "8 GB RAM", new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(1808), "40 GB available space" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CPU", "GPU", "OS", "RAM", "ReleaseDate", "Storage" },
                values: new object[] { "Intel® Core™ 2 Duo E6600 or AMD Phenom™ X3 8750 processor or better", "Video card must be 256 MB or more and should be a DirectX 9-compatible with support for Pixel Shader 3.0", "Windows® 7/Vista/XP", "2 GB RAM", new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(1811), "15 GB available space" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalNotes",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "CPU",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "GPU",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "OS",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "RAM",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Storage",
                table: "Games");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 978, DateTimeKind.Utc).AddTicks(1389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(4506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(9774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(2855));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(9554),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(2694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(4477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 504, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.AddColumn<long>(
                name: "SystemRequirementId",
                table: "Games",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(3427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 503, DateTimeKind.Utc).AddTicks(9991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(3253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 19, 38, 37, 503, DateTimeKind.Utc).AddTicks(9732));

            migrationBuilder.CreateTable(
                name: "SystemRequirements",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<long>(type: "bigint", nullable: false),
                    AdditionalNotes = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CPU = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    GPU = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    OS = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RAM = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Storage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemRequirements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemRequirements_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ReleaseDate", "SystemRequirementId" },
                values: new object[] { new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(8586), 1L });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ReleaseDate", "SystemRequirementId" },
                values: new object[] { new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(8598), 2L });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ReleaseDate", "SystemRequirementId" },
                values: new object[] { new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(8601), 3L });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedOn",
                value: new DateTime(2023, 8, 12, 12, 54, 34, 978, DateTimeKind.Utc).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2023, 8, 12, 12, 54, 34, 978, DateTimeKind.Utc).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2023, 8, 12, 12, 54, 34, 978, DateTimeKind.Utc).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedOn",
                value: new DateTime(2023, 8, 12, 12, 54, 34, 978, DateTimeKind.Utc).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedOn",
                value: new DateTime(2023, 8, 12, 12, 54, 34, 978, DateTimeKind.Utc).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostedOn",
                value: new DateTime(2023, 8, 12, 12, 54, 34, 978, DateTimeKind.Utc).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "PostedOn",
                value: new DateTime(2023, 8, 12, 12, 54, 34, 978, DateTimeKind.Utc).AddTicks(1526));

            migrationBuilder.InsertData(
                table: "SystemRequirements",
                columns: new[] { "Id", "AdditionalNotes", "CPU", "GPU", "GameId", "OS", "RAM", "Storage" },
                values: new object[,]
                {
                    { 1L, "SSD recommended, 60 FPS, 1920x1080 in ultra", "AMD Ryzen 3 1200 or Intel Core i5-2500", "4 GB VRAM, AMD Radeon R9 380 or NVIDIA GeForce GTX 960 DirectX: Version 12", 1L, "Windows 10 (20H1 version or newer, 64-bit versions)", "8 GB RAM", "90 GB available space" },
                    { 2L, null, "Intel Core i5-2500K | AMD FX-8350", "NVIDIA GeForce GTX 960 (2 GB) | AMD Radeon RX 480", 2L, "Windows 7", "8 GB RAM", "40 GB available space" },
                    { 3L, null, "Intel® Core™ 2 Duo E6600 or AMD Phenom™ X3 8750 processor or better", "Video card must be 256 MB or more and should be a DirectX 9-compatible with support for Pixel Shader 3.0", 3L, "Windows® 7/Vista/XP", "2 GB RAM", "15 GB available space" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SystemRequirements_GameId",
                table: "SystemRequirements",
                column: "GameId",
                unique: true);
        }
    }
}
