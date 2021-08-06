using Microsoft.EntityFrameworkCore.Migrations;

namespace Engine.Data.Migrations.AppDb
{
    public partial class ImagePath2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Tableware",
                newName: "ImagePath");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Recipe",
                newName: "ImagePath");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "IngredientCategory",
                newName: "ImagePath");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "Tableware",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "Recipe",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "IngredientCategory",
                newName: "Image");
        }
    }
}
