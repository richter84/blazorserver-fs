using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorServerService.Data.Migrations
{
    public partial class UpdatedElectricalSafetyToCollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ElectricalSafety",
                table: "ElectricOperation");

            migrationBuilder.CreateTable(
                name: "ElectricalSafetySelection",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElectricalSafety = table.Column<int>(nullable: false),
                    ElectricOperationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricalSafetySelection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectricalSafetySelection_ElectricOperation_ElectricOperationId",
                        column: x => x.ElectricOperationId,
                        principalTable: "ElectricOperation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElectricalSafetySelection_ElectricOperationId",
                table: "ElectricalSafetySelection",
                column: "ElectricOperationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElectricalSafetySelection");

            migrationBuilder.AddColumn<int>(
                name: "ElectricalSafety",
                table: "ElectricOperation",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
