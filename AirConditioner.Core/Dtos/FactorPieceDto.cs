using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Dtos
{
    public class FactorPieceDto
    {
        public int Id { get; set; }

        public string Comment { get; set; }
        public bool IsChange { get; set; }
        public double Value { get; set; }
        public double PriceOne { get; set; }
        public double PriceTotal { get; set; }

        public int PieceId { get; set; }
        public string PieceName { get; set; }
        public PieceDto PieceDto { get; set; }

        public int FactorId { get; set; }
    }
}
