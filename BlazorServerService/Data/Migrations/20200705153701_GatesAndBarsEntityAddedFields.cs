using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorServerService.Data.Migrations
{
    public partial class GatesAndBarsEntityAddedFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "FH",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FW",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsHingedLeaf",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsHingesBottomTrack",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Leafs",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "OverTracksSize",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RollerShutterDoor_FireDefence",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SectionalDoor_OverJambSize",
                table: "Door",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FH",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "FW",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "IsHingedLeaf",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "IsHingesBottomTrack",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "Leafs",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "OverTracksSize",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "RollerShutterDoor_FireDefence",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "SectionalDoor_OverJambSize",
                table: "Door");
        }
    }
}
