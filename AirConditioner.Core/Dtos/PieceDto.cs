using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AirConditioner.Core.Dtos
{
    public class PieceDto
    {
        public int Id { get; set; }

        [DisplayName("نام قطعه")]
        public string Name { get; set; }

        [DisplayName("قیمت")]
        public double Price { get; set; }

        [DisplayName("درصد نسبت به قیمت")]
        public int Percent { get; set; }
    }
}
