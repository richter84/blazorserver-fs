using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorServerService.Data.Migrations
{
    public partial class ElectricOperations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElectricalSafetySelection_ElectricOperation_ElectricOperationId",
                table: "ElectricalSafetySelection");

            migrationBuilder.AlterColumn<int>(
                name: "ElectricOperationId",
                table: "ElectricalSafetySelection",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricalSafetySelection_ElectricOperation_ElectricOperationId",
                table: "ElectricalSafetySelection",
                column: "ElectricOperationId",
                principalTable: "ElectricOperation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElectricalSafetySelection_ElectricOperation_ElectricOperationId",
                table: "ElectricalSafetySelection");

            migrationBuilder.AlterColumn<int>(
                name: "ElectricOperationId",
                table: "ElectricalSafetySelection",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricalSafetySelection_ElectricOperation_ElectricOperationId",
                table: "ElectricalSafetySelection",
                column: "ElectricOperationId",
                principalTable: "ElectricOperation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
