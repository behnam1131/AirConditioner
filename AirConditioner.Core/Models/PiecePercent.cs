using System;

namespace AirConditioner.Core.Models
{
    public class PiecePercent
    {
        public int Id { get; set; }
        public string DateFa { get; set; }
        public string Time { get; set; }
        public DateTime ChangeDateTime { get; set; }
        public int Percent { get; set; }

        public int PieceId { get; set; }
        public Piece Piece { get; set; }



    }



}
