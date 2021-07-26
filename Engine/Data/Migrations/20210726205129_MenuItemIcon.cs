using Microsoft.EntityFrameworkCore.Migrations;

namespace Engine.Data.Migrations
{
    public partial class MenuItemIcon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "MenuItem",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "MenuItem");
        }
    }
}
