using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Dtos
{
    public class PieceDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Percent { get; set; }
    }
}
