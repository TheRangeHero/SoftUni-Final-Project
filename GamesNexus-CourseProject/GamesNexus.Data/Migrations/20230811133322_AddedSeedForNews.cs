using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesNexus.Data.Migrations
{
    public partial class AddedSeedForNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(9065),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 143, DateTimeKind.Utc).AddTicks(2452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(7518),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 143, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(7309),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 143, DateTimeKind.Utc).AddTicks(658));

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "News",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(650)",
                oldMaxLength: 650);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(2607),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 142, DateTimeKind.Utc).AddTicks(5786));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(1697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 142, DateTimeKind.Utc).AddTicks(4769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(1515),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 142, DateTimeKind.Utc).AddTicks(4593));

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

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Content", "PublishedOn", "PublisherId", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec interdum dictum pellentesque. In orci sem, iaculis a dolor vitae, pellentesque placerat odio. Vivamus tincidunt ex ipsum, eu elementum tortor scelerisque quis. Sed faucibus malesuada eros. Integer vitae imperdiet lectus. Ut fermentum placerat mi ut suscipit. Mauris nec viverra velit.Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla pulvinar lobortis turpis, ac porttitor nulla consectetur in. In id nibh sem. Donec ut semper sem. Phasellus pharetra faucibus sapien nec .", new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(7367), new Guid("dae07e76-9f5d-4bfb-800b-c0dfb0efec5b"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ligula leo, pulvinar sed ullamcorper et, laoreet in odio." },
                    { 2, "Lorem ipsum dolor, consectetur adipiscing elit. Donec interdum dictum pellentesque. In orci sem, iaculis a dolor vitae, pellentesque placerat odio. Vivamus tincidunt ex ipsum, eu elementum tortor scelerisque quis. Sed faucibus malesuada eros. Integer vitae imperdiet lectus. Ut fermentum placerat mi ut suscipit. Mauris nec viverra velit. Nulla pulvinar lobortis turpis, ac porttitor nulla consectetur in. In id nibh sem. Donec ut semper sem. Phasellus pharetra faucibus sapien nec .", new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(7371), new Guid("dae07e76-9f5d-4bfb-800b-c0dfb0efec5b"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ligula leo, pulvinar sed ullamcorper et, laoreet in odio. Phasellus elementum." },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec interdum dictum pellentesque. In orci sem, iaculis a dolor vitae, pellentesque placerat odio. Vivamus tincidunt ex ipsum, eu elementum tortor scelerisque quis. Sed faucibus malesuada eros. Integer vitae imperdiet lectus. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla pulvinar lobortis turpis, ac porttitor nulla consectetur in. In id nibh sem. Donec ut semper sem. Phasellus pharetra faucibus sapien nec .", new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(7372), new Guid("dae07e76-9f5d-4bfb-800b-c0dfb0efec5b"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Leo, pulvinar sed ullamcorper et, laoreet in odio. Phasellus elementum." },
                    { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec interdum dictum pellentesque. In orci sem, iaculis a dolor vitae, pellentesque placerat odio. Vivamus tincidunt ex ipsum, eu elementum tortor scelerisque quis. Integer vitae imperdiet lectus. Ut fermentum placerat mi ut suscipit. Mauris nec viverra velit.Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla pulvinar lobortis turpis, ac porttitor nulla consectetur in. In id nibh sem. Donec ut semper sem. Phasellus pharetra faucibus sapien nec .", new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(7373), new Guid("dae07e76-9f5d-4bfb-800b-c0dfb0efec5b"), "Lorem ipsum dolor sit amet. Phasellus ligula leo laoreet in odio. Phasellus elementum." },
                    { 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In orci sem, iaculis a dolor vitae, pellentesque placerat odio. Vivamus tincidunt ex ipsum, eu elementum tortor scelerisque quis. Sed faucibus malesuada eros. Integer vitae imperdiet lectus. Ut fermentum placerat mi ut suscipit. Mauris nec viverra velit. Malesuada fames ac ante ipsum primis in faucibus. Nulla pulvinar lobortis turpis, ac porttitor nulla consectetur in. In id nibh sem. Donec ut semper sem. Phasellus pharetra faucibus sapien nec .", new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(7375), new Guid("dae07e76-9f5d-4bfb-800b-c0dfb0efec5b"), "Consectetur adipiscing elit. Phasellus ligula leo, pulvinar sed ullamcorper et, laoreet in odio. Phasellus elementum." },
                    { 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nterdum dictum pellentesque. In orci sem, iaculis a dolor vitae, pellentesque placerat odio. Vivamus tincidunt ex ipsum, eu elementum tortor scelerisque quis. Sed faucibus malesuada eros. Integer vitae imperdiet lectus. Ut fermentum placerat mi ut suscipit. Mauris nec viverra velit.Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla pulvinar lobortis turpis In id nibh sem. Donec ut semper sem. Phasellus pharetra faucibus sapien nec .", new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(7376), new Guid("dae07e76-9f5d-4bfb-800b-c0dfb0efec5b"), "Laoreet in odio. Phasellus elementum." }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 143, DateTimeKind.Utc).AddTicks(2452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(9065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 143, DateTimeKind.Utc).AddTicks(870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(7518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedOn",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 143, DateTimeKind.Utc).AddTicks(658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(7309));

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "News",
                type: "nvarchar(650)",
                maxLength: 650,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 142, DateTimeKind.Utc).AddTicks(5786),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(2607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Discussions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 142, DateTimeKind.Utc).AddTicks(4769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 12, 25, 6, 142, DateTimeKind.Utc).AddTicks(4593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 13, 33, 22, 178, DateTimeKind.Utc).AddTicks(1515));

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
        }
    }
}
