using AirConditioner.Core.Dtos;
using AirConditioner.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Interfaces
{
    public interface IAirConditionerModelService
    {
        bool Add(AirConditionerModelDto airConditionerModelDto);
        List<AirConditionerModelDto> GetAll();
    }
}
