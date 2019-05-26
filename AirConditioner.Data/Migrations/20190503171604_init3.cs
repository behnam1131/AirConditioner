using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirConditioner.Data.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactorPiecePrices_Factors_FactorId",
                table: "FactorPiecePrices");

            migrationBuilder.DropForeignKey(
                name: "FK_FactorPiecePrices_Pieces_PieceId",
                table: "FactorPiecePrices");

            migrationBuilder.DropForeignKey(
                name: "FK_Factors_AirConditionerNames_AirConditionerNameId",
                table: "Factors");

            migrationBuilder.DropTable(
                name: "AirConditionerNames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FactorPiecePrices",
                table: "FactorPiecePrices");

            migrationBuilder.RenameTable(
                name: "FactorPiecePrices",
                newName: "FactorPieces");

            migrationBuilder.RenameColumn(
                name: "comment",
                table: "Factors",
                newName: "Comment");

            migrationBuilder.RenameColumn(
                name: "AirConditionerNameId",
                table: "Factors",
                newName: "AirConditionerModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Factors_AirConditionerNameId",
                table: "Factors",
                newName: "IX_Factors_AirConditionerModelId");

            migrationBuilder.RenameColumn(
                name: "priceTotal",
                table: "FactorPieces",
                newName: "PriceTotal");

            migrationBuilder.RenameColumn(
                name: "priceOne",
                table: "FactorPieces",
                newName: "PriceOne");

            migrationBuilder.RenameColumn(
                name: "comment",
                table: "FactorPieces",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_FactorPiecePrices_PieceId",
                table: "FactorPieces",
                newName: "IX_FactorPieces_PieceId");

            migrationBuilder.RenameIndex(
                name: "IX_FactorPiecePrices_FactorId",
                table: "FactorPieces",
                newName: "IX_FactorPieces_FactorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FactorPieces",
                table: "FactorPieces",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AirConditionerModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirConditionerModels", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_FactorPieces_Factors_FactorId",
                table: "FactorPieces",
                column: "FactorId",
                principalTable: "Factors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FactorPieces_Pieces_PieceId",
                table: "FactorPieces",
                column: "PieceId",
                principalTable: "Pieces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Factors_AirConditionerModels_AirConditionerModelId",
                table: "Factors",
                column: "AirConditionerModelId",
                principalTable: "AirConditionerModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactorPieces_Factors_FactorId",
                table: "FactorPieces");

            migrationBuilder.DropForeignKey(
                name: "FK_FactorPieces_Pieces_PieceId",
                table: "FactorPieces");

            migrationBuilder.DropForeignKey(
                name: "FK_Factors_AirConditionerModels_AirConditionerModelId",
                table: "Factors");

            migrationBuilder.DropTable(
                name: "AirConditionerModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FactorPieces",
                table: "FactorPieces");

            migrationBuilder.RenameTable(
                name: "FactorPieces",
                newName: "FactorPiecePrices");

            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "Factors",
                newName: "comment");

            migrationBuilder.RenameColumn(
                name: "AirConditionerModelId",
                table: "Factors",
                newName: "AirConditionerNameId");

            migrationBuilder.RenameIndex(
                name: "IX_Factors_AirConditionerModelId",
                table: "Factors",
                newName: "IX_Factors_AirConditionerNameId");

            migrationBuilder.RenameColumn(
                name: "PriceTotal",
                table: "FactorPiecePrices",
                newName: "priceTotal");

            migrationBuilder.RenameColumn(
                name: "PriceOne",
                table: "FactorPiecePrices",
                newName: "priceOne");

            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "FactorPiecePrices",
                newName: "comment");

            migrationBuilder.RenameIndex(
                name: "IX_FactorPieces_PieceId",
                table: "FactorPiecePrices",
                newName: "IX_FactorPiecePrices_PieceId");

            migrationBuilder.RenameIndex(
                name: "IX_FactorPieces_FactorId",
                table: "FactorPiecePrices",
                newName: "IX_FactorPiecePrices_FactorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FactorPiecePrices",
                table: "FactorPiecePrices",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AirConditionerNames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirConditionerNames", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_FactorPiecePrices_Factors_FactorId",
                table: "FactorPiecePrices",
                column: "FactorId",
                principalTable: "Factors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FactorPiecePrices_Pieces_PieceId",
                table: "FactorPiecePrices",
                column: "PieceId",
                principalTable: "Pieces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Factors_AirConditionerNames_AirConditionerNameId",
                table: "Factors",
                column: "AirConditionerNameId",
                principalTable: "AirConditionerNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
