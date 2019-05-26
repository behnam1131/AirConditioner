using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Web.ViewModels
{
    public class UserOperatorVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public List<FactorVM> FactorVMs { get; set; }
    }

}
