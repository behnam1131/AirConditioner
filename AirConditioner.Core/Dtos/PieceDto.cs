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

        [DisplayName(" قیمت برای مشتری")]
        public double PriceCustomer { get { return Price + (Price * PercentCustomer / 100); } }

        [DisplayName(" قیمت برای همکار")]
        public double PriceColleague { get { return Price + (Price * PercentColleague / 100); } }

        [DisplayName("درصد برای مشتری")]
        public int PercentCustomer { get; set; }
        [DisplayName("درصد برای همکار")]
        public int PercentColleague { get; set; }
    }
}
