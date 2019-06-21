using System.Collections.Generic;

namespace AirConditioner.Core.Models
{
    public class Piece
    {
        public int Id { get; set; }
        public string Name { get; set; }      

        public virtual ICollection<FactorPiece> FactorPieces { get; set; }
        public virtual ICollection<PieceCost> PieceCosts { get; set; }

    }
}
