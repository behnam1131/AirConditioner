using AirConditioner.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Interfaces
{
    public interface IPiecePriceService
    {
        bool Add(double price, int pieceId);
    }
}
