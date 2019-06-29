using AirConditioner.Core.Dtos;
using AirConditioner.Helper;
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
        List<FactorDto> GetUserFactors(Actor actor, int userId, string fromDate, string toDate);
    }
}
