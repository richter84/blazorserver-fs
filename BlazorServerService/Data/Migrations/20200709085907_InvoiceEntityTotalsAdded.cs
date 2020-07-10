using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorServerService.Data.Migrations
{
    public partial class InvoiceEntityTotalsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Job_Door_DoorId",
                table: "Job");

            migrationBuilder.AlterColumn<int>(
                name: "DoorId",
                table: "Job",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SubTotal",
                table: "Invoice",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "VatTotal",
                table: "Invoice",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "InvoiceItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    InvoiceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceItem_Invoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItem_InvoiceId",
                table: "InvoiceItem",
                column: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Door_DoorId",
                table: "Job",
                column: "DoorId",
                principalTable: "Door",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Job_Door_DoorId",
                table: "Job");

            migrationBuilder.DropTable(
                name: "InvoiceItem");

            migrationBuilder.DropColumn(
                name: "SubTotal",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "VatTotal",
                table: "Invoice");

            migrationBuilder.AlterColumn<int>(
                name: "DoorId",
                table: "Job",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

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
