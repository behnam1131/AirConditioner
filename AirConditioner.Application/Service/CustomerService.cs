using AirConditioner.Core.Dtos;
using AirConditioner.Core.Interfaces;
using AirConditioner.Core.Models;
using AirConditioner.Data;
using AirConditioner.Helper;
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
                Code=e.Code,
                Address=e.Address,
                Phone=e.Phone
            }).ToList();

            return list;
        }

        public IQueryable<CustomerDto> GetQuery()
        {
            var list = _dbContext.Customers.AsQueryable().Select(e => new CustomerDto
            {
                Id = e.Id,
                Name = e.Name,
                Code = e.Code,
                Address = e.Address,
                Phone = e.Phone
            }); 

            return list;
        }


        public bool Add(CustomerDto customerDto)
        {
            Customer customer = new Customer
            {
                Name = customerDto.Name,
                Code=customerDto.Code,
                Address = customerDto.Address,
                
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
