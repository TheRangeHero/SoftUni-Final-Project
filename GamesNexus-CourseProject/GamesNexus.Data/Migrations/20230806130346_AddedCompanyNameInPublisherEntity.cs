using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesNexus.Data.Migrations
{
    public partial class AddedCompanyNameInPublisherEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 464, DateTimeKind.Utc).AddTicks(179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 4, 7, 43, 57, 118, DateTimeKind.Utc).AddTicks(601));

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Publishers",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(8838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 4, 7, 43, 57, 117, DateTimeKind.Utc).AddTicks(2528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(8650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 4, 7, 43, 57, 117, DateTimeKind.Utc).AddTicks(1932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(3857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 4, 7, 43, 57, 115, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(2935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 4, 7, 43, 57, 114, DateTimeKind.Utc).AddTicks(7026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(2776),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 4, 7, 43, 57, 114, DateTimeKind.Utc).AddTicks(6217));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Publishers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 4, 7, 43, 57, 118, DateTimeKind.Utc).AddTicks(601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 464, DateTimeKind.Utc).AddTicks(179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 4, 7, 43, 57, 117, DateTimeKind.Utc).AddTicks(2528),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(8838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 4, 7, 43, 57, 117, DateTimeKind.Utc).AddTicks(1932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 4, 7, 43, 57, 115, DateTimeKind.Utc).AddTicks(452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 4, 7, 43, 57, 114, DateTimeKind.Utc).AddTicks(7026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(2935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 4, 7, 43, 57, 114, DateTimeKind.Utc).AddTicks(6217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 6, 13, 3, 46, 463, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 4, 7, 43, 57, 116, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 4, 7, 43, 57, 116, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 4, 7, 43, 57, 116, DateTimeKind.Utc).AddTicks(8858));
        }
    }
}
