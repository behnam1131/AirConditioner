using AirConditioner.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirConditioner.Core.Interfaces
{
    public interface ICustomerService
    {
        CustomerDto Add(CustomerDto customerDto);
        CustomerDto GetById(int factorId);
        List<CustomerDto> GetAll();
        IQueryable<CustomerDto> GetQuery();
    }
}
