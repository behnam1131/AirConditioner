using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AirConditioner.Core.Dtos
{
    public class UserTechnicianDto
    {
        public int Id { get; set; }
        [DisplayName("نام و نام خانوادگی")]
        public string Name { get; set; }
        [DisplayName("موبایل")]
        public string Phone { get; set; }
    }
}
