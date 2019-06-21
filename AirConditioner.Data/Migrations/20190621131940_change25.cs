using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AirConditioner.Data.Migrations
{
    public partial class change25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "piecePercents");

            migrationBuilder.DropTable(
                name: "PiecePrices");

            migrationBuilder.DropColumn(
                name: "Percent",
                table: "Pieces");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Pieces");

            migrationBuilder.AddColumn<string>(
                name: "PieceName",
                table: "FactorPieces",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PieceCosts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Price = table.Column<double>(nullable: false),
                    PercentCustomer = table.Column<int>(nullable: false),
                    PercentColleague = table.Column<int>(nullable: false),
                    FromDateTime = table.Column<DateTime>(nullable: false),
                    ToDateTime = table.Column<DateTime>(nullable: true),
                    PieceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PieceCosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PieceCosts_Pieces_PieceId",
                        column: x => x.PieceId,
                        principalTable: "Pieces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PieceCosts_PieceId",
                table: "PieceCosts",
                column: "PieceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PieceCosts");

            migrationBuilder.DropColumn(
                name: "PieceName",
                table: "FactorPieces");

            migrationBuilder.AddColumn<int>(
                name: "Percent",
                table: "Pieces",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Pieces",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "piecePercents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ChangeDateTime = table.Column<DateTime>(nullable: false),
                    DateFa = table.Column<string>(nullable: true),
                    Percent = table.Column<int>(nullable: false),
                    PieceId = table.Column<int>(nullable: false),
                    Time = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_piecePercents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_piecePercents_Pieces_PieceId",
                        column: x => x.PieceId,
                        principalTable: "Pieces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PiecePrices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ChangeDateTime = table.Column<DateTime>(nullable: false),
                    DateFa = table.Column<string>(nullable: true),
                    PieceId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Time = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PiecePrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PiecePrices_Pieces_PieceId",
                        column: x => x.PieceId,
                        principalTable: "Pieces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_piecePercents_PieceId",
                table: "piecePercents",
                column: "PieceId");

            migrationBuilder.CreateIndex(
                name: "IX_PiecePrices_PieceId",
                table: "PiecePrices",
                column: "PieceId");
        }
    }
}
