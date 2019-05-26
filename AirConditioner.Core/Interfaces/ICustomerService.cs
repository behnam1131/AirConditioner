using AirConditioner.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Core.Interfaces
{
    public interface ICustomerService
    {
        bool Add(CustomerDto customerDto);
        List<CustomerDto> GetAll();
    }
}
