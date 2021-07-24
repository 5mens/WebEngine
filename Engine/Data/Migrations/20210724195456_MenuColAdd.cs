using Microsoft.EntityFrameworkCore.Migrations;

namespace Engine.Data.Migrations
{
    public partial class MenuColAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "Menu",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Published",
                table: "Menu",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Published",
                table: "Menu");
        }
    }
}
