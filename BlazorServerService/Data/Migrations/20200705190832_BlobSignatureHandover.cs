using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorServerService.Data.Migrations
{
    public partial class BlobSignatureHandover : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PointOfContactSignature",
                table: "Handover");

            migrationBuilder.AddColumn<byte[]>(
                name: "PointOfContactSignatureBlob",
                table: "Handover",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PointOfContactSignatureBlob",
                table: "Handover");

            migrationBuilder.AddColumn<string>(
                name: "PointOfContactSignature",
                table: "Handover",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }
    }
}
