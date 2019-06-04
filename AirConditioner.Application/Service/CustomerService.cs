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

        public CustomerDto GetById(int factorId)
        {
            var customerDto = _dbContext.Customers
                .Where(e=>e.Id== factorId)
                .Select(e => new CustomerDto
            {
                Id = e.Id,
                Name = e.Name,
                Code = e.Code,
                Address = e.Address,
                Phone = e.Phone
            }).FirstOrDefault();

            return customerDto;
        }


        public CustomerDto Add(CustomerDto customerDto)
        {
            Customer customer = new Customer
            {
                Name = customerDto.Name,
                Address = customerDto.Address,
                
                Phone = customerDto.Phone
            };
            try
            {
                _dbContext.Customers.Add(customer);
                _dbContext.SaveChanges();


                var customerEntity = _dbContext.Customers.Find(customer.Id);
                customerEntity.Code = GetCode(customer).ToString();

                _dbContext.SaveChanges();

                return GetById(customer.Id);

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int GetCode(Customer customer)
        {
            int customerId = _dbContext.Customers.Find(customer.Id).Id;

            return customerId == 0 ? 1000 : (1000 + customerId);
        }
    }
}
