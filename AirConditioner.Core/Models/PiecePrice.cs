using System;

namespace AirConditioner.Core.Models
{
    public class PiecePrice
    {
        public int Id { get; set; }
        public string DateFa { get; set; }
        public string Time { get; set; }
        public DateTime ChangeDateTime { get; set; }
        public double Price { get; set; }  // قیمت خرید  

        public int PieceId { get; set; }
        public Piece Piece { get; set; }


    }
}
