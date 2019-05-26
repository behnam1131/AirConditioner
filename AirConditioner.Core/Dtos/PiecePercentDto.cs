using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Dtos
{
    public class PiecePercentDto
    {
        public int Id { get; set; }
        public string DateFa { get; set; }
        public string Time { get; set; }
        public DateTime ChangeDateTime { get; set; }
        public int Percent { get; set; }
    }
}
