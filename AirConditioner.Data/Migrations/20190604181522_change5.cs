using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirConditioner.Data.Migrations
{
    public partial class change5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ChangeDateTime",
                table: "Factors",
                newName: "RegisterDateTime");

            migrationBuilder.AddColumn<DateTime>(
                name: "FactorDateTime",
                table: "Factors",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FactorDateTime",
                table: "Factors");

            migrationBuilder.RenameColumn(
                name: "RegisterDateTime",
                table: "Factors",
                newName: "ChangeDateTime");
        }
    }
}
