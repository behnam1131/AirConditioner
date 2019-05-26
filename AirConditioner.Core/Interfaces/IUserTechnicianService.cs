using AirConditioner.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Interfaces
{
    public interface IUserTechnicianService
    {
        bool Add(UserTechnicianDto userTechnicianDto);
        List<UserTechnicianDto> GetAll();
    }
}
