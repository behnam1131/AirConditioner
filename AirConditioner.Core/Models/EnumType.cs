using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Models
{
    public class EnumType
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int Code { get; set; }

        public virtual ICollection<EnumMember> EnumMembers { get; set; }

    }
}
