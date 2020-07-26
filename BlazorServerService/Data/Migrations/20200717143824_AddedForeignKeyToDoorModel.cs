using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorServerService.Data.Migrations
{
    public partial class AddedForeignKeyToDoorModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Job_Door_DoorId",
                table: "Job");

            migrationBuilder.DropIndex(
                name: "IX_Job_DoorId",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "DoorId",
                table: "Job");

            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "Door",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Door_JobId",
                table: "Door",
                column: "JobId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Door_Job_JobId",
                table: "Door",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Door_Job_JobId",
                table: "Door");

            migrationBuilder.DropIndex(
                name: "IX_Door_JobId",
                table: "Door");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Door");

            migrationBuilder.AddColumn<int>(
                name: "DoorId",
                table: "Job",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Job_DoorId",
                table: "Job",
                column: "DoorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Door_DoorId",
                table: "Job",
                column: "DoorId",
                principalTable: "Door",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
