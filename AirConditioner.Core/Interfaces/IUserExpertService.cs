﻿using AirConditioner.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Interfaces
{
    public interface IUserExpertService
    {
        bool Add(UserExpertDto userExpertDto);
        List<UserExpertDto> GetAll();
    }
}
