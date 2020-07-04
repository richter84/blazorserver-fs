using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorServerService.Data.Migrations
{
    public partial class UpdateRollerShutterPropertySizesToDoubles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Sectional_AntiFallSafety",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Cable",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sectional_ElectricOperationId",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LiftType",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfSprings",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sectional_OperationType",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "OverJambSize",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PanelOECSize",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ShaftLength",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ShaftSize",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SizeToSpringAssembly",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SpringLength",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SpringSize",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TopOfTrackSize",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Sectional_WicketEuroDoor",
                table: "Door",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Door_Sectional_ElectricOperationId",
                table: "Door",
                column: "Sectional_ElectricOperationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Door_ElectricOperation_Sectional_ElectricOperationId",
                table: "Door",
                column: "Sectional_ElectricOperationId",
                principalTable: "ElectricOperation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Door_ElectricOperation_Sectional_ElectricOperationId",
                table: "Door");

            migrationBuilder.DropIndex(
                name: "IX_Door_Sectional_ElectricOperationId",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "Sectional_AntiFallSafety",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "Cable",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "Sectional_ElectricOperationId",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "LiftType",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "NumberOfSprings",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "Sectional_OperationType",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "OverJambSize",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "PanelOECSize",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "ShaftLength",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "ShaftSize",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "SizeToSpringAssembly",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "SpringLength",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "SpringSize",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "TopOfTrackSize",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "Sectional_WicketEuroDoor",
                table: "Door");
        }
    }
}
