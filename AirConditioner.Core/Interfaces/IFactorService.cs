using AirConditioner.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Interfaces
{
    public interface IFactorService
    {
        FactorDto Add(FactorDto factorDto);
        List<FactorDto> GetAll();
        FactorDto GetById(int factorId);        
    }
}
