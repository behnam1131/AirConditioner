﻿using System.Collections.Generic;

namespace AirConditioner.Web.ViewModels
{
    public class UserAssistantVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public List<FactorVM> FactorVMs { get; set; }
    }
    
}
