using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesNexus.Data.Migrations
{
    public partial class FinalSeedForCategoriesAndGenres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 978, DateTimeKind.Utc).AddTicks(1389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(9065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(9774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(7518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(9554),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(7309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(4477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(2607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(3427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(3253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(1515));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Co-op" },
                    { 5, "Local & party" },
                    { 6, "Online Competitive" },
                    { 7, "Free to Play" },
                    { 8, "Early Access" },
                    { 9, "Demos" },
                    { 10, "Cross-Platform Multiplayer" },
                    { 11, "Full controller support" },
                    { 12, "Tracked Controller Support" },
                    { 13, "VR Only" },
                    { 14, "VR Supported" },
                    { 15, "Includes level editor" },
                    { 16, "Remote Play on Phone/tablet" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "First-Person Shooter");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 6, "Arcade & Rhythm" },
                    { 7, "Third-Person Shooter" },
                    { 8, "Platformer & Runner" },
                    { 9, "Hack & Slash" },
                    { 10, "Farming & Crafting" },
                    { 11, "Rogue-Like" },
                    { 12, "Strategy RPG" },
                    { 13, "Turn-Based" },
                    { 14, "Card & Board" },
                    { 15, "Tower Defense" },
                    { 16, "Puzzle" },
                    { 17, "All Sports" },
                    { 18, "Racing" },
                    { 19, "Racing Sim" },
                    { 20, "Sports Sim" },
                    { 21, "Horror" },
                    { 22, "Open world" },
                    { 23, "Survival" },
                    { 24, "Sci-Fi" },
                    { 25, "Space & Flight" },
                    { 26, "RPG" },
                    { 27, "Battle Royale" },
                    { 28, "MOBA" },
                    { 29, "MMO" }
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(9065),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 978, DateTimeKind.Utc).AddTicks(1389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(7518),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(9774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(7309),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(9554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(2607),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(4477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(1697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(1515),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 12, 54, 34, 977, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Shooter");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedOn",
                value: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedOn",
                value: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedOn",
                value: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostedOn",
                value: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "PostedOn",
                value: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(9187));
        }
    }
}
