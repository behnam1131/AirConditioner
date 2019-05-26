using AirConditioner.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Interfaces
{
    public interface IUserOperatorService
    {
        bool Add(UserOperatorDto userOperatorDto);
        List<UserOperatorDto> GetAll();
    }
}
