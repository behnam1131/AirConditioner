using Microsoft.EntityFrameworkCore.Migrations;

namespace AirConditioner.Data.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactorWorks_Factors_FactorId",
                table: "FactorWorks");

            migrationBuilder.AlterColumn<int>(
                name: "FactorId",
                table: "FactorWorks",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Value",
                table: "FactorPieces",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<double>(
                name: "PriceTotal",
                table: "FactorPieces",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<double>(
                name: "PriceOne",
                table: "FactorPieces",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AddForeignKey(
                name: "FK_FactorWorks_Factors_FactorId",
                table: "FactorWorks",
                column: "FactorId",
                principalTable: "Factors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactorWorks_Factors_FactorId",
                table: "FactorWorks");

            migrationBuilder.AlterColumn<int>(
                name: "FactorId",
                table: "FactorWorks",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<float>(
                name: "Value",
                table: "FactorPieces",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "PriceTotal",
                table: "FactorPieces",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "PriceOne",
                table: "FactorPieces",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AddForeignKey(
                name: "FK_FactorWorks_Factors_FactorId",
                table: "FactorWorks",
                column: "FactorId",
                principalTable: "Factors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
