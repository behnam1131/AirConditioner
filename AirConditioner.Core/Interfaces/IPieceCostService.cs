using AirConditioner.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Interfaces
{
    public interface IPieceCostService
    {
        bool Add(double price, int PercentCustomer, int PercentColleague, int pieceId);
        List<PieceCostDto> GetAll(int pieceId);
        PieceCostDto GetLast(int pieceId);
    }
}
