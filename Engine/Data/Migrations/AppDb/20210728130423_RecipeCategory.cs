using Microsoft.EntityFrameworkCore.Migrations;

namespace Engine.Data.Migrations.AppDb
{
    public partial class RecipeCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "MenuItem");

            migrationBuilder.DropColumn(
                name: "IdParentComment",
                table: "Comment");

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "Tableware",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Tableware",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "RecipeCategory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "RecipeCategory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentCategoyId",
                table: "RecipeCategory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Recipe",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentIdId",
                table: "MenuItem",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "IngredientCategory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "IngredientCategory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentCommentId",
                table: "Comment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RecipeCategory_ParentCategoyId",
                table: "RecipeCategory",
                column: "ParentCategoyId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_ParentIdId",
                table: "MenuItem",
                column: "ParentIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ParentCommentId",
                table: "Comment",
                column: "ParentCommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Comment_ParentCommentId",
                table: "Comment",
                column: "ParentCommentId",
                principalTable: "Comment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_MenuItem_ParentIdId",
                table: "MenuItem",
                column: "ParentIdId",
                principalTable: "MenuItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeCategory_RecipeCategory_ParentCategoyId",
                table: "RecipeCategory",
                column: "ParentCategoyId",
                principalTable: "RecipeCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Comment_ParentCommentId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_MenuItem_ParentIdId",
                table: "MenuItem");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeCategory_RecipeCategory_ParentCategoyId",
                table: "RecipeCategory");

            migrationBuilder.DropIndex(
                name: "IX_RecipeCategory_ParentCategoyId",
                table: "RecipeCategory");

            migrationBuilder.DropIndex(
                name: "IX_MenuItem_ParentIdId",
                table: "MenuItem");

            migrationBuilder.DropIndex(
                name: "IX_Comment_ParentCommentId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "Tableware");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Tableware");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "RecipeCategory");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "RecipeCategory");

            migrationBuilder.DropColumn(
                name: "ParentCategoyId",
                table: "RecipeCategory");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "ParentIdId",
                table: "MenuItem");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "IngredientCategory");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "IngredientCategory");

            migrationBuilder.DropColumn(
                name: "ParentCommentId",
                table: "Comment");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "MenuItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdParentComment",
                table: "Comment",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
