using AirConditioner.Core.Dtos;
using AirConditioner.Core.Interfaces;
using AirConditioner.Core.Models;
using AirConditioner.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirConditioner.Application.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext _dbContext;
        public CustomerService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<CustomerDto> GetAll()
        {
            var list = _dbContext.Customers.Select(e => new CustomerDto
            {
                Id = e.Id,
                Name = e.Name,
                address=e.address,
                Phone=e.Phone
            }).ToList();

            return list;
        }

        public bool Add(CustomerDto customerDto)
        {
            Customer customer = new Customer
            {
                Name = customerDto.Name,
                address = customerDto.address,
                Phone = customerDto.Phone
            };
            try
            {
                _dbContext.Customers.Add(customer);
                _dbContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
