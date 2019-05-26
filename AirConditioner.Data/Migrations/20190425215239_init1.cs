using Microsoft.EntityFrameworkCore.Migrations;

namespace AirConditioner.Data.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactorPiecePrices_PiecePrices_PiecePriceId",
                table: "FactorPiecePrices");

            migrationBuilder.DropForeignKey(
                name: "FK_Factors_EngineVolumes_EngineVolumeId",
                table: "Factors");

            migrationBuilder.DropForeignKey(
                name: "FK_piecePercents_Pieces_PieceId",
                table: "piecePercents");

            migrationBuilder.DropForeignKey(
                name: "FK_PiecePrices_Pieces_PieceId",
                table: "PiecePrices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EngineVolumes",
                table: "EngineVolumes");

            migrationBuilder.RenameTable(
                name: "EngineVolumes",
                newName: "EngineVolume");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "PiecePrices",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "PiecePriceId",
                table: "FactorPiecePrices",
                newName: "PieceId");

            migrationBuilder.RenameIndex(
                name: "IX_FactorPiecePrices_PiecePriceId",
                table: "FactorPiecePrices",
                newName: "IX_FactorPiecePrices_PieceId");

            migrationBuilder.AlterColumn<int>(
                name: "PieceId",
                table: "PiecePrices",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PieceId",
                table: "piecePercents",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EngineVolume",
                table: "EngineVolume",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FactorPiecePrices_Pieces_PieceId",
                table: "FactorPiecePrices",
                column: "PieceId",
                principalTable: "Pieces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Factors_EngineVolume_EngineVolumeId",
                table: "Factors",
                column: "EngineVolumeId",
                principalTable: "EngineVolume",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_piecePercents_Pieces_PieceId",
                table: "piecePercents",
                column: "PieceId",
                principalTable: "Pieces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PiecePrices_Pieces_PieceId",
                table: "PiecePrices",
                column: "PieceId",
                principalTable: "Pieces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactorPiecePrices_Pieces_PieceId",
                table: "FactorPiecePrices");

            migrationBuilder.DropForeignKey(
                name: "FK_Factors_EngineVolume_EngineVolumeId",
                table: "Factors");

            migrationBuilder.DropForeignKey(
                name: "FK_piecePercents_Pieces_PieceId",
                table: "piecePercents");

            migrationBuilder.DropForeignKey(
                name: "FK_PiecePrices_Pieces_PieceId",
                table: "PiecePrices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EngineVolume",
                table: "EngineVolume");

            migrationBuilder.RenameTable(
                name: "EngineVolume",
                newName: "EngineVolumes");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "PiecePrices",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "PieceId",
                table: "FactorPiecePrices",
                newName: "PiecePriceId");

            migrationBuilder.RenameIndex(
                name: "IX_FactorPiecePrices_PieceId",
                table: "FactorPiecePrices",
                newName: "IX_FactorPiecePrices_PiecePriceId");

            migrationBuilder.AlterColumn<int>(
                name: "PieceId",
                table: "PiecePrices",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PieceId",
                table: "piecePercents",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_EngineVolumes",
                table: "EngineVolumes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FactorPiecePrices_PiecePrices_PiecePriceId",
                table: "FactorPiecePrices",
                column: "PiecePriceId",
                principalTable: "PiecePrices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Factors_EngineVolumes_EngineVolumeId",
                table: "Factors",
                column: "EngineVolumeId",
                principalTable: "EngineVolumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_piecePercents_Pieces_PieceId",
                table: "piecePercents",
                column: "PieceId",
                principalTable: "Pieces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PiecePrices_Pieces_PieceId",
                table: "PiecePrices",
                column: "PieceId",
                principalTable: "Pieces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
