using Microsoft.EntityFrameworkCore.Migrations;

namespace Engine.Data.Migrations.AppDb
{
    public partial class Warehouse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyWarehouseId",
                table: "Tableware",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserTableware",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTableware", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTableware_Tableware_Id",
                        column: x => x.Id,
                        principalTable: "Tableware",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Warehouse_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserIngredient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MyWarehouseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserIngredient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserIngredient_Ingredient_Id",
                        column: x => x.Id,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserIngredient_Warehouse_MyWarehouseId",
                        column: x => x.MyWarehouseId,
                        principalTable: "Warehouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tableware_MyWarehouseId",
                table: "Tableware",
                column: "MyWarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserIngredient_MyWarehouseId",
                table: "UserIngredient",
                column: "MyWarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_UserId",
                table: "Warehouse",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tableware_Warehouse_MyWarehouseId",
                table: "Tableware",
                column: "MyWarehouseId",
                principalTable: "Warehouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tableware_Warehouse_MyWarehouseId",
                table: "Tableware");

            migrationBuilder.DropTable(
                name: "UserIngredient");

            migrationBuilder.DropTable(
                name: "UserTableware");

            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.DropIndex(
                name: "IX_Tableware_MyWarehouseId",
                table: "Tableware");

            migrationBuilder.DropColumn(
                name: "MyWarehouseId",
                table: "Tableware");
        }
    }
}
