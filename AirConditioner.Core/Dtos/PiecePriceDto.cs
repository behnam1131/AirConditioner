using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Dtos
{
    public class PiecePriceDto
    {
        public int Id { get; set; }
        public string DateFa { get; set; }
        public string Time { get; set; }
        public DateTime ChangeDateTime { get; set; }
        public double price { get; set; }  // قیمت خرید  

        public int PieceId { get; set; }
    }
}
