using Microsoft.EntityFrameworkCore.Migrations;

namespace Engine.Data.Migrations.AppDb
{
    public partial class WHMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserIngredient_Ingredient_IngredientId",
                table: "UserIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTableware_Tableware_TablewareId",
                table: "UserTableware");

            migrationBuilder.AlterColumn<int>(
                name: "TablewareId",
                table: "UserTableware",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IngredientId",
                table: "UserIngredient",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserIngredient_Ingredient_IngredientId",
                table: "UserIngredient",
                column: "IngredientId",
                principalTable: "Ingredient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTableware_Tableware_TablewareId",
                table: "UserTableware",
                column: "TablewareId",
                principalTable: "Tableware",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserIngredient_Ingredient_IngredientId",
                table: "UserIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTableware_Tableware_TablewareId",
                table: "UserTableware");

            migrationBuilder.AlterColumn<int>(
                name: "TablewareId",
                table: "UserTableware",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IngredientId",
                table: "UserIngredient",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
