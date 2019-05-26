using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Models
{
    public class AirConditionerModel
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public virtual ICollection<Factor> Factors { get; set; }
    }
}
