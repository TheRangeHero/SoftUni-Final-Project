using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesNexus.Data.Migrations
{
    public partial class AddedIsActiveBoolForSoftDeleting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 23, 42, 18, 595, DateTimeKind.Utc).AddTicks(1541),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 401, DateTimeKind.Utc).AddTicks(1037));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Reviews",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 23, 42, 18, 595, DateTimeKind.Utc).AddTicks(82),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(9541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 23, 42, 18, 594, DateTimeKind.Utc).AddTicks(9926),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(9365));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "News",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 23, 42, 18, 594, DateTimeKind.Utc).AddTicks(8936),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Games",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 23, 42, 18, 594, DateTimeKind.Utc).AddTicks(8016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(7399));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Discussions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 23, 42, 18, 594, DateTimeKind.Utc).AddTicks(7812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Comments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "IsActive", "ReleaseDate" },
                values: new object[] { true, new DateTime(2023, 8, 13, 23, 42, 18, 594, DateTimeKind.Utc).AddTicks(9277) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "IsActive", "ReleaseDate" },
                values: new object[] { true, new DateTime(2023, 8, 13, 23, 42, 18, 594, DateTimeKind.Utc).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "IsActive", "ReleaseDate" },
                values: new object[] { true, new DateTime(2023, 8, 13, 23, 42, 18, 594, DateTimeKind.Utc).AddTicks(9291) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsActive", "PublishedOn" },
                values: new object[] { true, new DateTime(2023, 8, 13, 23, 42, 18, 594, DateTimeKind.Utc).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsActive", "PublishedOn" },
                values: new object[] { true, new DateTime(2023, 8, 13, 23, 42, 18, 594, DateTimeKind.Utc).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsActive", "PublishedOn" },
                values: new object[] { true, new DateTime(2023, 8, 13, 23, 42, 18, 594, DateTimeKind.Utc).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsActive", "PublishedOn" },
                values: new object[] { true, new DateTime(2023, 8, 13, 23, 42, 18, 594, DateTimeKind.Utc).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsActive", "PublishedOn" },
                values: new object[] { true, new DateTime(2023, 8, 13, 23, 42, 18, 594, DateTimeKind.Utc).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IsActive", "PublishedOn" },
                values: new object[] { true, new DateTime(2023, 8, 13, 23, 42, 18, 594, DateTimeKind.Utc).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsActive", "PostedOn" },
                values: new object[] { true, new DateTime(2023, 8, 13, 23, 42, 18, 595, DateTimeKind.Utc).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsActive", "PostedOn" },
                values: new object[] { true, new DateTime(2023, 8, 13, 23, 42, 18, 595, DateTimeKind.Utc).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsActive", "PostedOn" },
                values: new object[] { true, new DateTime(2023, 8, 13, 23, 42, 18, 595, DateTimeKind.Utc).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsActive", "PostedOn" },
                values: new object[] { true, new DateTime(2023, 8, 13, 23, 42, 18, 595, DateTimeKind.Utc).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsActive", "PostedOn" },
                values: new object[] { true, new DateTime(2023, 8, 13, 23, 42, 18, 595, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IsActive", "PostedOn" },
                values: new object[] { true, new DateTime(2023, 8, 13, 23, 42, 18, 595, DateTimeKind.Utc).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IsActive", "PostedOn" },
                values: new object[] { true, new DateTime(2023, 8, 13, 23, 42, 18, 595, DateTimeKind.Utc).AddTicks(1667) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "News");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Discussions");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Comments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 401, DateTimeKind.Utc).AddTicks(1037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 23, 42, 18, 595, DateTimeKind.Utc).AddTicks(1541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(9541),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 23, 42, 18, 595, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(9365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 23, 42, 18, 594, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(8380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 23, 42, 18, 594, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(7399),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 23, 42, 18, 594, DateTimeKind.Utc).AddTicks(8016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(7209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 23, 42, 18, 594, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 400, DateTimeKind.Utc).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 401, DateTimeKind.Utc).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 401, DateTimeKind.Utc).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 401, DateTimeKind.Utc).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 401, DateTimeKind.Utc).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 401, DateTimeKind.Utc).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 401, DateTimeKind.Utc).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "PostedOn",
                value: new DateTime(2023, 8, 13, 18, 28, 30, 401, DateTimeKind.Utc).AddTicks(1153));
        }
    }
}
