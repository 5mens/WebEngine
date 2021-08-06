using Microsoft.EntityFrameworkCore.Migrations;

namespace Engine.Data.Migrations.AppDb
{
    public partial class Ingredient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeCategory_RecipeCategory_ParentCategoyId",
                table: "RecipeCategory");

            migrationBuilder.RenameColumn(
                name: "ParentCategoyId",
                table: "RecipeCategory",
                newName: "UserRecipeCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeCategory_ParentCategoyId",
                table: "RecipeCategory",
                newName: "IX_RecipeCategory_UserRecipeCategoryId");

            migrationBuilder.AddColumn<bool>(
                name: "ShowDetails",
                table: "RecipeCategory",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeCategory_RecipeCategory_UserRecipeCategoryId",
                table: "RecipeCategory",
                column: "UserRecipeCategoryId",
                principalTable: "RecipeCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientCategory_IngredientCategory_CategoryId",
                table: "IngredientCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeCategory_RecipeCategory_UserRecipeCategoryId",
                table: "RecipeCategory");

            migrationBuilder.DropIndex(
                name: "IX_IngredientCategory_CategoryId",
                table: "IngredientCategory");

            migrationBuilder.DropColumn(
                name: "ShowDetails",
                table: "RecipeCategory");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "IngredientCategory");

            migrationBuilder.RenameColumn(
                name: "UserRecipeCategoryId",
                table: "RecipeCategory",
                newName: "ParentCategoyId");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeCategory_UserRecipeCategoryId",
                table: "RecipeCategory",
                newName: "IX_RecipeCategory_ParentCategoyId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeCategory_RecipeCategory_ParentCategoyId",
                table: "RecipeCategory",
                column: "ParentCategoyId",
                principalTable: "RecipeCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
