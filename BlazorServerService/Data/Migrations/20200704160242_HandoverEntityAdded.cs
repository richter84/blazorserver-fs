using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorServerService.Data.Migrations
{
    public partial class HandoverEntityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HandoverId",
                table: "Job",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InvoiceNumber",
                table: "Invoice",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "Invoice",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Handover",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlsIfApplicable = table.Column<bool>(nullable: false),
                    Demonstration = table.Column<bool>(nullable: false),
                    IsCompleteByEngineer = table.Column<bool>(nullable: false),
                    PointOfContactName = table.Column<bool>(nullable: false),
                    PointOfContactSignature = table.Column<string>(maxLength: 100, nullable: true),
                    SafetyDevicesExplained = table.Column<bool>(nullable: false),
                    ServiceScheduleLog = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Handover", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Job_HandoverId",
                table: "Job",
                column: "HandoverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Handover_HandoverId",
                table: "Job",
                column: "HandoverId",
                principalTable: "Handover",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Job_Handover_HandoverId",
                table: "Job");

            migrationBuilder.DropTable(
                name: "Handover");

            migrationBuilder.DropIndex(
                name: "IX_Job_HandoverId",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "HandoverId",
                table: "Job");

            migrationBuilder.AlterColumn<string>(
                name: "InvoiceNumber",
                table: "Invoice",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "Invoice",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
