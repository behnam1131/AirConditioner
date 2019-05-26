using System.Collections.Generic;

namespace AirConditioner.Core.Models
{
    public class UserAssistant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Factor> Factors { get; set; }
    }
    
}
