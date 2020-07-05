using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorServerService.Data.Migrations
{
    public partial class SectionalPedestrianEntityAddedFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Door_ElectricOperation_Sectional_ElectricOperationId",
                table: "Door");

            migrationBuilder.RenameColumn(
                name: "Sectional_WicketEuroDoor",
                table: "Door",
                newName: "SectionalDoor_WicketEuroDoor");

            migrationBuilder.RenameColumn(
                name: "Sectional_OperationType",
                table: "Door",
                newName: "SectionalDoor_OperationType");

            migrationBuilder.RenameColumn(
                name: "Sectional_ElectricOperationId",
                table: "Door",
                newName: "SectionalDoor_ElectricOperationId");

            migrationBuilder.RenameColumn(
                name: "Sectional_AntiFallSafety",
                table: "Door",
                newName: "SectionalDoor_AntiFallSafety");

            migrationBuilder.RenameIndex(
                name: "IX_Door_Sectional_ElectricOperationId",
                table: "Door",
                newName: "IX_Door_SectionalDoor_ElectricOperationId");

            migrationBuilder.AddColumn<int>(
                name: "ElectricalEntry",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HandleType",
                table: "Door",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCloser",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsElectricalEntry",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFireEscape",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsMagLock",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfLockingPoints",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SizeOverStandardHeight",
                table: "Door",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SizeOverStandardWidth",
                table: "Door",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Door_ElectricOperation_SectionalDoor_ElectricOperationId",
                table: "Door",
                column: "SectionalDoor_ElectricOperationId",
                principalTable: "ElectricOperation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Door_ElectricOperation_SectionalDoor_ElectricOperationId",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "ElectricalEntry",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "HandleType",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "IsCloser",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "IsElectricalEntry",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "IsFireEscape",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "IsMagLock",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "NumberOfLockingPoints",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "SizeOverStandardHeight",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "SizeOverStandardWidth",
                table: "Door");

            migrationBuilder.RenameColumn(
                name: "SectionalDoor_WicketEuroDoor",
                table: "Door",
                newName: "Sectional_WicketEuroDoor");

            migrationBuilder.RenameColumn(
                name: "SectionalDoor_OperationType",
                table: "Door",
                newName: "Sectional_OperationType");

            migrationBuilder.RenameColumn(
                name: "SectionalDoor_ElectricOperationId",
                table: "Door",
                newName: "Sectional_ElectricOperationId");

            migrationBuilder.RenameColumn(
                name: "SectionalDoor_AntiFallSafety",
                table: "Door",
                newName: "Sectional_AntiFallSafety");

            migrationBuilder.RenameIndex(
                name: "IX_Door_SectionalDoor_ElectricOperationId",
                table: "Door",
                newName: "IX_Door_Sectional_ElectricOperationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Door_ElectricOperation_Sectional_ElectricOperationId",
                table: "Door",
                column: "Sectional_ElectricOperationId",
                principalTable: "ElectricOperation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
