using AirConditioner.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Interfaces
{
    public interface IUserAssistantService
    {
        bool Add(UserAssistantDto userAssistantDto);
        List<UserAssistantDto> GetAll();
      }
}
