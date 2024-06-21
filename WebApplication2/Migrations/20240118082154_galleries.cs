using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class galleries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_gallerys",
                table: "gallerys");

            migrationBuilder.RenameTable(
                name: "gallerys",
                newName: "galleries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_galleries",
                table: "galleries",
                column: "Gallery_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_galleries",
                table: "galleries");

            migrationBuilder.RenameTable(
                name: "galleries",
                newName: "gallerys");

            migrationBuilder.AddPrimaryKey(
                name: "PK_gallerys",
                table: "gallerys",
                column: "Gallery_Id");
        }
    }
}
