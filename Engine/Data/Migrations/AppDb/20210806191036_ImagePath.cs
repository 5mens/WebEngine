using Microsoft.EntityFrameworkCore.Migrations;

namespace Engine.Data.Migrations.AppDb
{
    public partial class ImagePath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tableware_Warehouse_MyWarehouseId",
                table: "Tableware");

            migrationBuilder.DropIndex(
                name: "IX_Tableware_MyWarehouseId",
                table: "Tableware");

            migrationBuilder.DropColumn(
                name: "MyWarehouseId",
                table: "Tableware");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Ingredient",
                newName: "ImagePath");

            migrationBuilder.AddColumn<int>(
                name: "MyWarehouseId",
                table: "UserTableware",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "UserTableware",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "UserIngredient",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "UserIngredient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserUnit",
                table: "UserIngredient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserTableware_MyWarehouseId",
                table: "UserTableware",
                column: "MyWarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTableware_Warehouse_MyWarehouseId",
                table: "UserTableware",
                column: "MyWarehouseId",
                principalTable: "Warehouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTableware_Warehouse_MyWarehouseId",
                table: "UserTableware");

            migrationBuilder.DropIndex(
                name: "IX_UserTableware_MyWarehouseId",
                table: "UserTableware");

            migrationBuilder.DropColumn(
                name: "MyWarehouseId",
                table: "UserTableware");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "UserTableware");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "UserIngredient");

            migrationBuilder.DropColumn(
                name: "UserUnit",
                table: "UserIngredient");

            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "Ingredient",
                newName: "Image");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "UserIngredient",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MyWarehouseId",
                table: "Tableware",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tableware_MyWarehouseId",
                table: "Tableware",
                column: "MyWarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tableware_Warehouse_MyWarehouseId",
                table: "Tableware",
                column: "MyWarehouseId",
                principalTable: "Warehouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
