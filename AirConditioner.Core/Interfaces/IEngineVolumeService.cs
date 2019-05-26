using AirConditioner.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Interfaces
{
    public interface IEngineVolumeService
    {
        bool Add(EngineVolumeDto engineVolumeDto);
        List<EngineVolumeDto> GetAll();
    }
}
