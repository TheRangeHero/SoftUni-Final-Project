using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesNexus.Data.Migrations
{
    public partial class FixedThePropertyNamingInGenreAndCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Genres",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Categories",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Genres",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "Type");
        }
    }
}
