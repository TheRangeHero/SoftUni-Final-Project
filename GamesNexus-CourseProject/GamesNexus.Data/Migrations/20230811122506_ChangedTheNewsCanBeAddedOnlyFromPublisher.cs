using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesNexus.Data.Migrations
{
    public partial class ChangedTheNewsCanBeAddedOnlyFromPublisher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_AspNetUsers_ApplicationUserId",
                table: "News");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "News",
                newName: "PublisherId");

            migrationBuilder.RenameIndex(
                name: "IX_News_ApplicationUserId",
                table: "News",
                newName: "IX_News_PublisherId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 143, DateTimeKind.Utc).AddTicks(2452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 10, 15, 49, 16, 843, DateTimeKind.Utc).AddTicks(6358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 143, DateTimeKind.Utc).AddTicks(870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 10, 15, 49, 16, 843, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 143, DateTimeKind.Utc).AddTicks(658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 10, 15, 49, 16, 843, DateTimeKind.Utc).AddTicks(4778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 142, DateTimeKind.Utc).AddTicks(5786),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 10, 15, 49, 16, 842, DateTimeKind.Utc).AddTicks(9995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 142, DateTimeKind.Utc).AddTicks(4769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 10, 15, 49, 16, 842, DateTimeKind.Utc).AddTicks(9012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 142, DateTimeKind.Utc).AddTicks(4593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 10, 15, 49, 16, 842, DateTimeKind.Utc).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 11, 12, 25, 6, 142, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 11, 12, 25, 6, 142, DateTimeKind.Utc).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 11, 12, 25, 6, 142, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedOn",
                value: new DateTime(2023, 8, 11, 12, 25, 6, 143, DateTimeKind.Utc).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2023, 8, 11, 12, 25, 6, 143, DateTimeKind.Utc).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2023, 8, 11, 12, 25, 6, 143, DateTimeKind.Utc).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedOn",
                value: new DateTime(2023, 8, 11, 12, 25, 6, 143, DateTimeKind.Utc).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedOn",
                value: new DateTime(2023, 8, 11, 12, 25, 6, 143, DateTimeKind.Utc).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostedOn",
                value: new DateTime(2023, 8, 11, 12, 25, 6, 143, DateTimeKind.Utc).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "PostedOn",
                value: new DateTime(2023, 8, 11, 12, 25, 6, 143, DateTimeKind.Utc).AddTicks(2583));

            migrationBuilder.AddForeignKey(
                name: "FK_News_Publishers_PublisherId",
                table: "News",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Publishers_PublisherId",
                table: "News");

            migrationBuilder.RenameColumn(
                name: "PublisherId",
                table: "News",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_News_PublisherId",
                table: "News",
                newName: "IX_News_ApplicationUserId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 10, 15, 49, 16, 843, DateTimeKind.Utc).AddTicks(6358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 143, DateTimeKind.Utc).AddTicks(2452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 10, 15, 49, 16, 843, DateTimeKind.Utc).AddTicks(4979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 143, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 10, 15, 49, 16, 843, DateTimeKind.Utc).AddTicks(4778),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 143, DateTimeKind.Utc).AddTicks(658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 10, 15, 49, 16, 842, DateTimeKind.Utc).AddTicks(9995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 142, DateTimeKind.Utc).AddTicks(5786));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 10, 15, 49, 16, 842, DateTimeKind.Utc).AddTicks(9012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 142, DateTimeKind.Utc).AddTicks(4769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 10, 15, 49, 16, 842, DateTimeKind.Utc).AddTicks(8838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 142, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 10, 15, 49, 16, 843, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 10, 15, 49, 16, 843, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 10, 15, 49, 16, 843, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedOn",
                value: new DateTime(2023, 8, 10, 15, 49, 16, 843, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2023, 8, 10, 15, 49, 16, 843, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2023, 8, 10, 15, 49, 16, 843, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedOn",
                value: new DateTime(2023, 8, 10, 15, 49, 16, 843, DateTimeKind.Utc).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedOn",
                value: new DateTime(2023, 8, 10, 15, 49, 16, 843, DateTimeKind.Utc).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostedOn",
                value: new DateTime(2023, 8, 10, 15, 49, 16, 843, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "PostedOn",
                value: new DateTime(2023, 8, 10, 15, 49, 16, 843, DateTimeKind.Utc).AddTicks(6481));

            migrationBuilder.AddForeignKey(
                name: "FK_News_AspNetUsers_ApplicationUserId",
                table: "News",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
