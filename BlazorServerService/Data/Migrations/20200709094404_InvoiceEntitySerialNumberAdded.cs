using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorServerService.Data.Migrations
{
    public partial class InvoiceEntitySerialNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceNumber",
                table: "Invoice");

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "Invoice",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "Invoice");

            migrationBuilder.AddColumn<string>(
                name: "InvoiceNumber",
                table: "Invoice",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
