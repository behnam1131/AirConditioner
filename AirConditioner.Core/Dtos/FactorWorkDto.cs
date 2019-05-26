using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Dtos
{
    public class FactorWorkDto
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public double Price { get; set; }

        public int FactorId { get; set; }
        

        public int WorkId { get; set; }
        public string WorkName { get; set; }
    }
}
