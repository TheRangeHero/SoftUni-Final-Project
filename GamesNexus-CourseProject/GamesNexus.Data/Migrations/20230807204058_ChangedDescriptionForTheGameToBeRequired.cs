using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesNexus.Data.Migrations
{
    public partial class ChangedDescriptionForTheGameToBeRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 745, DateTimeKind.Utc).AddTicks(5814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 493, DateTimeKind.Utc).AddTicks(7594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 745, DateTimeKind.Utc).AddTicks(4411),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 493, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 745, DateTimeKind.Utc).AddTicks(4250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 493, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 744, DateTimeKind.Utc).AddTicks(9257),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 493, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Games",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 744, DateTimeKind.Utc).AddTicks(8255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 492, DateTimeKind.Utc).AddTicks(9889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 744, DateTimeKind.Utc).AddTicks(8062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 492, DateTimeKind.Utc).AddTicks(9709));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 493, DateTimeKind.Utc).AddTicks(7594),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 745, DateTimeKind.Utc).AddTicks(5814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 493, DateTimeKind.Utc).AddTicks(6191),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 745, DateTimeKind.Utc).AddTicks(4411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 493, DateTimeKind.Utc).AddTicks(5981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 745, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 493, DateTimeKind.Utc).AddTicks(870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 744, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Games",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 492, DateTimeKind.Utc).AddTicks(9889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 744, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 15, 0, 37, 492, DateTimeKind.Utc).AddTicks(9709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 20, 40, 57, 744, DateTimeKind.Utc).AddTicks(8062));

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
    }
}
