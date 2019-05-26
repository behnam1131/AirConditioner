using AirConditioner.Core.Dtos;
using System.Collections.Generic;

namespace AirConditioner.Core.Interfaces
{
    public interface IFactorWorkService
    {
        bool Add(FactorWorkDto factorWorkDto);
        bool Add(List<FactorWorkDto> factorWorkDtos);
        List<FactorWorkDto> GetAll();
    }
}
