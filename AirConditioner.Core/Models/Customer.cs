using System.Collections.Generic;

namespace AirConditioner.Core.Models
{
    public class Customer   //مشتری
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string address { get; set; }

        public virtual ICollection<Factor> Factors { get; set; }
    }

}
