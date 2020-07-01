using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorServerService.Data.Migrations
{
    public partial class JobEntityNewInstallEntityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "Customer");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastUpdated",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateTable(
                name: "ElectricOperation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Control = table.Column<string>(nullable: true),
                    ElectricalSafety = table.Column<int>(nullable: false),
                    MotorType = table.Column<string>(nullable: true),
                    SupplyType = table.Column<int>(nullable: false),
                    PECQty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricOperation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Door",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Colour = table.Column<string>(nullable: true),
                    ExtraNotes = table.Column<string>(nullable: true),
                    FixingType = table.Column<string>(nullable: true),
                    IsSupplied = table.Column<bool>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    OpeningSizeHeight = table.Column<double>(nullable: false),
                    OpeningSizeWidth = table.Column<double>(nullable: false),
                    Sector = table.Column<int>(nullable: false),
                    SupplierOrderNumber = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    AngleCutSize = table.Column<string>(nullable: true),
                    AngleType = table.Column<string>(nullable: true),
                    AntiFallSafety = table.Column<int>(nullable: true),
                    Canopy = table.Column<bool>(nullable: true),
                    CanopyType = table.Column<string>(nullable: true),
                    CanopyCutSize = table.Column<string>(nullable: true),
                    CurtainType = table.Column<string>(nullable: true),
                    ElectricOperationId = table.Column<int>(nullable: true),
                    Fascia = table.Column<bool>(nullable: true),
                    FasciaType = table.Column<string>(nullable: true),
                    FasciaSize = table.Column<string>(nullable: true),
                    FireDefence = table.Column<int>(nullable: true),
                    GuideCutSize = table.Column<string>(nullable: true),
                    GuideType = table.Column<string>(nullable: true),
                    IsBoltOnGuides = table.Column<bool>(nullable: true),
                    LathCutSize = table.Column<double>(nullable: true),
                    OperationType = table.Column<int>(nullable: true),
                    TubeTypeGauge = table.Column<string>(nullable: true),
                    RollerCutSize = table.Column<string>(nullable: true),
                    WicketEuroDoor = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Door", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Door_ElectricOperation_ElectricOperationId",
                        column: x => x.ElectricOperationId,
                        principalTable: "ElectricOperation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNumber = table.Column<string>(nullable: true),
                    DoorId = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Created = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Job_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Job_Door_DoorId",
                        column: x => x.DoorId,
                        principalTable: "Door",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoryStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Entry = table.Column<DateTimeOffset>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    JobId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryStatus_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    JobId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoice_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Door_ElectricOperationId",
                table: "Door",
                column: "ElectricOperationId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryStatus_JobId",
                table: "HistoryStatus",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_JobId",
                table: "Invoice",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Job_CustomerId",
                table: "Job",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Job_DoorId",
                table: "Job",
                column: "DoorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoryStatus");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "Door");

            migrationBuilder.DropTable(
                name: "ElectricOperation");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "Customer");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastUpdate",
                table: "Customer",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
