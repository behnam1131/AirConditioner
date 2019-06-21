using System;

namespace AirConditioner.Core.Models
{
    public class PieceCost
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int PercentCustomer { get; set; }
        public int PercentColleague { get; set; }

        public DateTime FromDateTime { get; set; }
        public DateTime? ToDateTime { get; set; }

        public int PieceId { get; set; }
        public Piece Piece { get; set; }
    }
}
