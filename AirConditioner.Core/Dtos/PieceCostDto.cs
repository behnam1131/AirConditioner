using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Dtos
{
    public class PieceCostDto
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int PercentCustomer { get; set; }
        public int PercentColleague { get; set; }

        public DateTime FromDateTime { get; set; }
        public DateTime? ToDateTime { get; set; }

        public int PieceId { get; set; }
        public PieceDto PieceDto { get; set; }
    }
}
