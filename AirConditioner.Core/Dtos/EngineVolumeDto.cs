using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AirConditioner.Core.Dtos
{
    public class EngineVolumeDto
    {
        public int Id { get; set; }

        [DisplayName("عنوان")]
        public string Name { get; set; }

    }
}
