using Microsoft.EntityFrameworkCore.Migrations;

namespace Engine.Data.Migrations.AppDb
{
    public partial class WHMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TablewareId",
                table: "UserTableware",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IngredientId",
                table: "UserIngredient",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserTableware_TablewareId",
                table: "UserTableware",
                column: "TablewareId");

            migrationBuilder.CreateIndex(
                name: "IX_UserIngredient_IngredientId",
                table: "UserIngredient",
                column: "IngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserIngredient_Ingredient_IngredientId",
                table: "UserIngredient",
                column: "IngredientId",
                principalTable: "Ingredient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTableware_Tableware_TablewareId",
                table: "UserTableware",
                column: "TablewareId",
                principalTable: "Tableware",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserIngredient_Ingredient_IngredientId",
                table: "UserIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTableware_Tableware_TablewareId",
                table: "UserTableware");

            migrationBuilder.DropIndex(
                name: "IX_UserTableware_TablewareId",
                table: "UserTableware");

            migrationBuilder.DropIndex(
                name: "IX_UserIngredient_IngredientId",
                table: "UserIngredient");

            migrationBuilder.DropColumn(
                name: "TablewareId",
                table: "UserTableware");

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "UserIngredient");
        }
    }
}
