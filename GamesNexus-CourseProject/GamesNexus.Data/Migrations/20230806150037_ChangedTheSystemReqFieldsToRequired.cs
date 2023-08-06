using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesNexus.Data.Migrations
{
    public partial class ChangedTheSystemReqFieldsToRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Storage",
                table: "SystemRequirements",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RAM",
                table: "SystemRequirements",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OS",
                table: "SystemRequirements",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GPU",
                table: "SystemRequirements",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPU",
                table: "SystemRequirements",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 493, DateTimeKind.Utc).AddTicks(7594),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 464, DateTimeKind.Utc).AddTicks(179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 493, DateTimeKind.Utc).AddTicks(6191),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(8838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 493, DateTimeKind.Utc).AddTicks(5981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 493, DateTimeKind.Utc).AddTicks(870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 492, DateTimeKind.Utc).AddTicks(9889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(2935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 492, DateTimeKind.Utc).AddTicks(9709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 6, 15, 0, 37, 493, DateTimeKind.Utc).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 6, 15, 0, 37, 493, DateTimeKind.Utc).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 6, 15, 0, 37, 493, DateTimeKind.Utc).AddTicks(5075));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Storage",
                table: "SystemRequirements",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "RAM",
                table: "SystemRequirements",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "OS",
                table: "SystemRequirements",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "GPU",
                table: "SystemRequirements",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "CPU",
                table: "SystemRequirements",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 464, DateTimeKind.Utc).AddTicks(179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 493, DateTimeKind.Utc).AddTicks(7594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(8838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 493, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(8650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 493, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(3857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 493, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(2935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 492, DateTimeKind.Utc).AddTicks(9889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(2776),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 492, DateTimeKind.Utc).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(7786));
        }
    }
}
