using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorServerService.Data.Migrations
{
    public partial class UpdatedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Job_Door_DoorId",
                table: "Job");

            migrationBuilder.AlterColumn<int>(
                name: "DoorId",
                table: "Job",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Door_DoorId",
                table: "Job",
                column: "DoorId",
                principalTable: "Door",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Job_Door_DoorId",
                table: "Job");

            migrationBuilder.AlterColumn<int>(
                name: "DoorId",
                table: "Job",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Door_DoorId",
                table: "Job",
                column: "DoorId",
                principalTable: "Door",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
