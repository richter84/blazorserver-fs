using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorServerService.Data.Migrations
{
    public partial class InvoiceEntityUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Job_JobId",
                table: "Invoice");

            migrationBuilder.AlterColumn<int>(
                name: "JobId",
                table: "Invoice",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Job_JobId",
                table: "Invoice",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Job_JobId",
                table: "Invoice");

            migrationBuilder.AlterColumn<int>(
                name: "JobId",
                table: "Invoice",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Job_JobId",
                table: "Invoice",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
