using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Web.ViewModels
{
    public class AirConditionerNameVM
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public List<FactorVM> FactorVMs { get; set; }
    }
}
