using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Models
{
    public class EnumMember
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Code { get; set; }

        public int EnumTypeId { get; set; }
        public EnumType EnumType { get; set; }
    }
}
