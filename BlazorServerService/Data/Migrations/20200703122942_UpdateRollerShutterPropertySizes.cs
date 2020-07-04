using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorServerService.Data.Migrations
{
    public partial class UpdateRollerShutterPropertySizes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BGSize",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FHSize",
                table: "Door",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BGSize",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "FHSize",
                table: "Door");
        }
    }
}
