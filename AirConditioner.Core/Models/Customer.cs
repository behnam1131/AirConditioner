using System.Collections.Generic;

namespace AirConditioner.Core.Models
{
    public class Customer   //مشتری
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Factor> Factors { get; set; }
    }

}
