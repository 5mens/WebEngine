using Microsoft.EntityFrameworkCore.Migrations;

namespace Engine.Data.Migrations.AppDb
{
    public partial class CategoriesIngredients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientCategory_IngredientCategory_CategoryId",
                table: "IngredientCategory");

            migrationBuilder.DropIndex(
                name: "IX_IngredientCategory_CategoryId",
                table: "IngredientCategory");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "IngredientCategory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "IngredientCategory",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IngredientCategory_CategoryId",
                table: "IngredientCategory",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientCategory_IngredientCategory_CategoryId",
                table: "IngredientCategory",
                column: "CategoryId",
                principalTable: "IngredientCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
