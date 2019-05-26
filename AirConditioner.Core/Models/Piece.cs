using System.Collections.Generic;

namespace AirConditioner.Core.Models
{
    public class Piece
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Percent { get; set; }
        public virtual ICollection<PiecePrice> PiecePrices { get; set; }
        public virtual ICollection<PiecePercent> PiecePercents { get; set; }

        public virtual ICollection<FactorPiece> FactorPieces { get; set; }

    }
}
