using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Web.ViewModels
{
   public class EngineVolumeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<FactorVM> FactorVMs { get; set; }
    }
}
