using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AirConditioner.Core.Dtos
{
    public class AirConditionerModelDto
    {
        public int Id { set; get; }

        [DisplayName("عنوان")]
        public string Name { set; get; }
    }
}
