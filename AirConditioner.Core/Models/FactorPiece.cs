namespace AirConditioner.Core.Models
{
    public class FactorPiece
    {
        public int Id { get; set; }

        public string Comment { get; set; }
        public string PieceName { get; set; }
        public bool IsChange { get; set; }
        public double Value { get; set; }
        public double PriceOne { get; set; }
        public double PriceTotal { get; set; }

        public int PieceId { get; set; }
        public Piece Piece { get; set; }

        public int FactorId { get; set; }
        public Factor Factor { get; set; }
    }

}
