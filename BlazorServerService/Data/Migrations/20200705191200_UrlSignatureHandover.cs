using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorServerService.Data.Migrations
{
    public partial class UrlSignatureHandover : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PointOfContactSignatureBlob",
                table: "Handover");

            migrationBuilder.AddColumn<string>(
                name: "PointOfContactSignatureUrl",
                table: "Handover",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PointOfContactSignatureUrl",
                table: "Handover");

            migrationBuilder.AddColumn<byte[]>(
                name: "PointOfContactSignatureBlob",
                table: "Handover",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
