using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Models
{
   public class EngineVolume
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Factor> Factors { get; set; }
    }
}
