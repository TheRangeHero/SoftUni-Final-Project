using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesNexus.Data.Migrations
{
    public partial class AddedSystemReqForTheGamesAndFixedTheOrderRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Orders_OrderId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_OrderId",
                table: "Games");

            migrationBuilder.DeleteData(
                table: "GamesCategories",
                keyColumns: new[] { "CategoryId", "GameId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "GamesCategories",
                keyColumns: new[] { "CategoryId", "GameId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "GamesGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "GamesGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "GamesGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "GamesGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Games");

            migrationBuilder.AlterColumn<long>(
                name: "GameId",
                table: "Reviews",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "GameId",
                table: "GamesVideos",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "GameId",
                table: "GamesImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "GameId",
                table: "GamesGenres",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "GameId",
                table: "GamesCategories",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Games",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "SystemRequirementId",
                table: "Games",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    GameId = table.Column<long>(type: "bigint", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => new { x.GameId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_OrderDetail_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SystemRequirement",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GPU = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CPU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RAM = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemRequirement", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "ApplicationUserId", "Description", "Developer", "Price", "PublisherId", "ReleaseDate", "SystemRequirementId", "Title" },
                values: new object[] { 1L, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras tellus nunc, porttitor vel sapien eget, ornare tristique mauris. Donec diam neque, auctor et dui non.", "Riot Games", 10.25m, new Guid("a9ac2bf7-c3e8-4597-841b-21a6ce1b766b"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), 0L, "League of Legends" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "ApplicationUserId", "Description", "Developer", "Price", "PublisherId", "ReleaseDate", "SystemRequirementId", "Title" },
                values: new object[] { 2L, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque consectetur gravida orci in dapibus. Mauris pharetra efficitur nisi ut vehicula. Nulla dapibus faucibus gravida. Nunc a eleifend sem, at tempus ante. Nunc tincidunt laoreet nisl, at viverra mauris ultricies iaculis. Nullam dui leo, mattis eu rutrum sed, vehicula at odio.", "Insomniac Games", 55.55m, new Guid("a9ac2bf7-c3e8-4597-841b-21a6ce1b766b"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), 0L, "Spyro" });

            migrationBuilder.InsertData(
                table: "GamesCategories",
                columns: new[] { "CategoryId", "GameId" },
                values: new object[,]
                {
                    { 2, 1L },
                    { 1, 2L }
                });

            migrationBuilder.InsertData(
                table: "GamesGenres",
                columns: new[] { "GameId", "GenreId" },
                values: new object[,]
                {
                    { 1L, 1 },
                    { 1L, 2 },
                    { 2L, 1 },
                    { 2L, 3 }
                });

            migrationBuilder.UpdateData(
                table: "GamesImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "GameId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "GamesImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "GameId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "GamesImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "GameId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "GamesVideos",
                keyColumn: "Id",
                keyValue: 1,
                column: "GameId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "GamesVideos",
                keyColumn: "Id",
                keyValue: 2,
                column: "GameId",
                value: 2L);

            migrationBuilder.CreateIndex(
                name: "IX_Games_SystemRequirementId",
                table: "Games",
                column: "SystemRequirementId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_SystemRequirement_SystemRequirementId",
                table: "Games",
                column: "SystemRequirementId",
                principalTable: "SystemRequirement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_SystemRequirement_SystemRequirementId",
                table: "Games");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "SystemRequirement");

            migrationBuilder.DropIndex(
                name: "IX_Games_SystemRequirementId",
                table: "Games");

            migrationBuilder.DeleteData(
                table: "GamesCategories",
                keyColumns: new[] { "CategoryId", "GameId" },
                keyValues: new object[] { 2, 1L });

            migrationBuilder.DeleteData(
                table: "GamesCategories",
                keyColumns: new[] { "CategoryId", "GameId" },
                keyValues: new object[] { 1, 2L });

            migrationBuilder.DeleteData(
                table: "GamesGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 1L, 1 });

            migrationBuilder.DeleteData(
                table: "GamesGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 1L, 2 });

            migrationBuilder.DeleteData(
                table: "GamesGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 2L, 1 });

            migrationBuilder.DeleteData(
                table: "GamesGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 2L, 3 });

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DropColumn(
                name: "SystemRequirementId",
                table: "Games");

            migrationBuilder.AlterColumn<int>(
                name: "GameId",
                table: "Reviews",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "GameId",
                table: "GamesVideos",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "GameId",
                table: "GamesImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "GameId",
                table: "GamesGenres",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "GameId",
                table: "GamesCategories",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Games",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<Guid>(
                name: "OrderId",
                table: "Games",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "ApplicationUserId", "Description", "Developer", "OrderId", "Price", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { 1, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras tellus nunc, porttitor vel sapien eget, ornare tristique mauris. Donec diam neque, auctor et dui non.", "Riot Games", null, 10.25m, new Guid("a9ac2bf7-c3e8-4597-841b-21a6ce1b766b"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "League of Legends" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "ApplicationUserId", "Description", "Developer", "OrderId", "Price", "PublisherId", "ReleaseDate", "Title" },
                values: new object[] { 2, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque consectetur gravida orci in dapibus. Mauris pharetra efficitur nisi ut vehicula. Nulla dapibus faucibus gravida. Nunc a eleifend sem, at tempus ante. Nunc tincidunt laoreet nisl, at viverra mauris ultricies iaculis. Nullam dui leo, mattis eu rutrum sed, vehicula at odio.", "Insomniac Games", null, 55.55m, new Guid("a9ac2bf7-c3e8-4597-841b-21a6ce1b766b"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Spyro" });

            migrationBuilder.InsertData(
                table: "GamesCategories",
                columns: new[] { "CategoryId", "GameId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "GamesGenres",
                columns: new[] { "GameId", "GenreId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 3 }
                });

            migrationBuilder.UpdateData(
                table: "GamesImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "GameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "GamesImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "GameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "GamesImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "GameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "GamesVideos",
                keyColumn: "Id",
                keyValue: 1,
                column: "GameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "GamesVideos",
                keyColumn: "Id",
                keyValue: 2,
                column: "GameId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Games_OrderId",
                table: "Games",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Orders_OrderId",
                table: "Games",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
