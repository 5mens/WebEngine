using Microsoft.EntityFrameworkCore.Migrations;

namespace Engine.Data.Migrations.AppDb
{
    public partial class DescToDescr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "Tableware",
                newName: "Descr");

            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "RecipeCategory",
                newName: "Descr");

            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "Recipe",
                newName: "Descr");

            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "Order",
                newName: "Descr");

            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "MenuItem",
                newName: "Descr");

            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "Menu",
                newName: "Descr");

            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "Ingredient",
                newName: "Descr");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descr",
                table: "Tableware",
                newName: "Desc");

            migrationBuilder.RenameColumn(
                name: "Descr",
                table: "RecipeCategory",
                newName: "Desc");

            migrationBuilder.RenameColumn(
                name: "Descr",
                table: "Recipe",
                newName: "Desc");

            migrationBuilder.RenameColumn(
                name: "Descr",
                table: "Order",
                newName: "Desc");

            migrationBuilder.RenameColumn(
                name: "Descr",
                table: "MenuItem",
                newName: "Desc");

            migrationBuilder.RenameColumn(
                name: "Descr",
                table: "Menu",
                newName: "Desc");

            migrationBuilder.RenameColumn(
                name: "Descr",
                table: "Ingredient",
                newName: "Desc");
        }
    }
}
