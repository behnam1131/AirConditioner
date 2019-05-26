using AirConditioner.Core.Dtos;
using System.Collections.Generic;

namespace AirConditioner.Core.Interfaces
{
    public interface IWorkService
    {
        bool Add(WorkDto workDto);
        List<WorkDto> GetAll();
    }
}
