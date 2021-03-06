﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Models
{
    public class UserOperator
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Factor> Factors { get; set; }
    }

}
