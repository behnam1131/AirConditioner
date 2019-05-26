using AirConditioner.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Interfaces
{
    public interface IPiecePercentService
    {
        bool Add(int Percent, int pieceId);
    }
}
