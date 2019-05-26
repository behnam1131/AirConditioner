using AirConditioner.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Interfaces
{
    public interface IFactorPieceService
    {
        bool Add(FactorPieceDto factorPieceDto);
        bool Add(List<FactorPieceDto> factorPieceDtos);
        List<FactorPieceDto> GetAll();
    }
}
