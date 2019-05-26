using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Models
{
    public class Work
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FactorWork> FactorWorks { get; set; }

    }
}
