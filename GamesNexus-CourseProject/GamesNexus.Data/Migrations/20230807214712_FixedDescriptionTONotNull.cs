using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesNexus.Data.Migrations
{
    public partial class FixedDescriptionTONotNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 897, DateTimeKind.Utc).AddTicks(3677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 745, DateTimeKind.Utc).AddTicks(5814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 897, DateTimeKind.Utc).AddTicks(2352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 745, DateTimeKind.Utc).AddTicks(4411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 897, DateTimeKind.Utc).AddTicks(2175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 745, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 896, DateTimeKind.Utc).AddTicks(7400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 744, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 896, DateTimeKind.Utc).AddTicks(6422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 744, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 896, DateTimeKind.Utc).AddTicks(6255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 744, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 7, 21, 47, 11, 897, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 7, 21, 47, 11, 897, DateTimeKind.Utc).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 7, 21, 47, 11, 897, DateTimeKind.Utc).AddTicks(1366));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 745, DateTimeKind.Utc).AddTicks(5814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 897, DateTimeKind.Utc).AddTicks(3677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 745, DateTimeKind.Utc).AddTicks(4411),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 897, DateTimeKind.Utc).AddTicks(2352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 745, DateTimeKind.Utc).AddTicks(4250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 897, DateTimeKind.Utc).AddTicks(2175));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 744, DateTimeKind.Utc).AddTicks(9257),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 896, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 744, DateTimeKind.Utc).AddTicks(8255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 896, DateTimeKind.Utc).AddTicks(6422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 744, DateTimeKind.Utc).AddTicks(8062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 896, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 7, 20, 40, 57, 745, DateTimeKind.Utc).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 7, 20, 40, 57, 745, DateTimeKind.Utc).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 7, 20, 40, 57, 745, DateTimeKind.Utc).AddTicks(3360));
        }
    }
}
