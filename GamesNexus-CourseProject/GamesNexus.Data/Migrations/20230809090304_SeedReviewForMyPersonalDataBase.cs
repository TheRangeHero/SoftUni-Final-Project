using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesNexus.Data.Migrations
{
    public partial class SeedReviewForMyPersonalDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 9, 9, 3, 4, 621, DateTimeKind.Utc).AddTicks(1312),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 897, DateTimeKind.Utc).AddTicks(3677));

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Reviews",
                type: "nvarchar(1600)",
                maxLength: 1600,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 9, 9, 3, 4, 620, DateTimeKind.Utc).AddTicks(9722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 897, DateTimeKind.Utc).AddTicks(2352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 9, 9, 3, 4, 620, DateTimeKind.Utc).AddTicks(9512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 897, DateTimeKind.Utc).AddTicks(2175));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 9, 9, 3, 4, 620, DateTimeKind.Utc).AddTicks(4310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 896, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 9, 9, 3, 4, 620, DateTimeKind.Utc).AddTicks(3300),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 896, DateTimeKind.Utc).AddTicks(6422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 9, 9, 3, 4, 620, DateTimeKind.Utc).AddTicks(3115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 896, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 9, 9, 3, 4, 620, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 9, 9, 3, 4, 620, DateTimeKind.Utc).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 9, 9, 3, 4, 620, DateTimeKind.Utc).AddTicks(8529));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "ApplicationUserId", "Comment", "GameId", "PostedOn", "Rating" },
                values: new object[,]
                {
                    { 1, new Guid("875b63f6-4c14-4757-bbc5-149615044a6f"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer suscipit porttitor dolor vel sagittis. Integer vulputate fringilla finibus.", 1L, new DateTime(2023, 8, 9, 9, 3, 4, 621, DateTimeKind.Utc).AddTicks(1435), 1 },
                    { 2, new Guid("19659aed-ed83-474b-9cb7-13e6140b8c3a"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed varius tempor sapien at rhoncus. Donec finibus lacinia eros at iaculis. Praesent tincidunt dui lorem, in convallis urna varius vel. Etiam vehicula eros finibus sapien tincidunt, at luctus sem tristique. Aenean quis eros lobortis est tempus porta. Phasellus sed dui in neque hendrerit tempor eu a turpis. Sed blandit mi eget magna eleifend commodo. Phasellus cursus purus a mi eleifend vehicula. In aliquam leo eu suscipit interdum. Aliquam quis ipsum in urna tristique viverra a et lectus. Vivamus metus nulla, cursus sit amet augue ac, egestas rutrum enim.", 1L, new DateTime(2023, 8, 9, 9, 3, 4, 621, DateTimeKind.Utc).AddTicks(1441), 2 },
                    { 3, new Guid("43ba6e1e-95b7-4f93-8324-a1f0300412d5"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dictum, diam quis lobortis facilisis, neque nisi pulvinar eros, ac porta lectus velit eu lacus. Sed posuere sapien vitae magna imperdiet, scelerisque tempor mi condimentum. Aliquam erat volutpat. Cras dolor elit, pharetra sit amet tristique.", 1L, new DateTime(2023, 8, 9, 9, 3, 4, 621, DateTimeKind.Utc).AddTicks(1443), 2 },
                    { 4, new Guid("875b63f6-4c14-4757-bbc5-149615044a6f"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dictum, diam quis lobortis facilisis, neque nisi pulvinar eros, ac porta lectus velit eu lacus. Sed posuere sapien vitae magna imperdiet, scelerisque tempor mi condimentum. Aliquam erat volutpat. Cras dolor elit, pharetra sit amet.", 2L, new DateTime(2023, 8, 9, 9, 3, 4, 621, DateTimeKind.Utc).AddTicks(1446), 1 },
                    { 5, new Guid("b33dcf98-79e3-4aea-bb2b-923601190998"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris molestie et nisi nec tempus. Fusce quis aliquet nisl. Nullam volutpat, sapien et accumsan vulputate, leo ligula convallis nulla, id hendrerit dolor tortor quis odio. Aenean pellentesque sagittis lacinia. Sed accumsan porttitor leo, sit amet ullamcorper sem molestie nec. Aenean maximus a diam at mattis. Donec in velit pellentesque mauris pretium fringilla ut ac erat.Etiam facilisis sapien sapien, et finibus sapien pretium id. Duis congue magna a lectus accumsan, sed ullamcorper leo tempor. Vestibulum vel efficitur magna, feugiat venenatis turpis. Etiam vulputate eros quis purus commodo auctor ut quis felis. Cras mollis tristique massa, sit amet semper elit varius eget. Donec eget diam id tortor aliquam sollicitudin ut nec ligula. Donec hendrerit augue id tortor iaculis bibendum. Aenean vulputate ante ut tincidunt aliquam.Donec vitae lacinia nisl, at sollicitudin metus. Sed pellentesque imperdiet eleifend. Integer scelerisque viverra nisl, ac imperdiet magna aliquam vel. Quisque in convallis dui. Pellentesque feugiat justo vitae mauris suscipit, sed malesuada tortor dapibus. Proin nec est aliquam, vulputate lectus sed, tristique velit. Maecenas quam orci, euismod at ultrices ac, pulvinar sed massa. Ut iaculis quis elementum. Nam vel dapibus nunc, vel ultricies ipsum. In.", 3L, new DateTime(2023, 8, 9, 9, 3, 4, 621, DateTimeKind.Utc).AddTicks(1448), 1 },
                    { 6, new Guid("875b63f6-4c14-4757-bbc5-149615044a6f"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus dapibus consequat eros eu sodales. Sed vel enim et risus tempor dignissim non et sem. Phasellus suscipit mi nibh, at ultricies odio blandit a. Cras posuere, ante sed egestas pretium, leo erat ullamcorper nisi, et condimentum ligula ligula vitae urna. Proin vel nunc iaculis, ornare libero et, mollis quam. Maecenas eu dui odio. Morbi mi mauris, consectetur vel est in, iaculis elementum sapien. Nulla luctus bibendum nisl, in pellentesque dolor.", 3L, new DateTime(2023, 8, 9, 9, 3, 4, 621, DateTimeKind.Utc).AddTicks(1450), 2 },
                    { 7, new Guid("43ba6e1e-95b7-4f93-8324-a1f0300412d5"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus dapibus consequat eros eu sodales. Sed vel enim et risus tempor dignissim non et sem. Phasellus suscipit mi nibh, at ultricies odio blandit a. Cras posuere, ante sed egestas pretium, leo erat ullamcorper nisi, et condimentum ligula ligula vitae urna. Proin vel nunc iaculis, ornare libero et, mollis quam. Maecenas eu dui odio. Morbi mi mauris, consectetur vel est in, iaculis elementum sapien. Nulla luctus bibendum nisl, in pellentesque dolor.", 3L, new DateTime(2023, 8, 9, 9, 3, 4, 621, DateTimeKind.Utc).AddTicks(1451), 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 897, DateTimeKind.Utc).AddTicks(3677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 9, 9, 3, 4, 621, DateTimeKind.Utc).AddTicks(1312));

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Reviews",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1600)",
                oldMaxLength: 1600);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 897, DateTimeKind.Utc).AddTicks(2352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 9, 9, 3, 4, 620, DateTimeKind.Utc).AddTicks(9722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 897, DateTimeKind.Utc).AddTicks(2175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 9, 9, 3, 4, 620, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 896, DateTimeKind.Utc).AddTicks(7400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 9, 9, 3, 4, 620, DateTimeKind.Utc).AddTicks(4310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 896, DateTimeKind.Utc).AddTicks(6422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 9, 9, 3, 4, 620, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 21, 47, 11, 896, DateTimeKind.Utc).AddTicks(6255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 9, 9, 3, 4, 620, DateTimeKind.Utc).AddTicks(3115));

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
    }
}
