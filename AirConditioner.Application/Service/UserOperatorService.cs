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
    public class UserOperatorService : IUserOperatorService
    {
        private readonly ApplicationDbContext _dbContext;
        public UserOperatorService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<UserOperatorDto> GetAll()
        {
            var list = _dbContext.UserOperators.Select(e => new UserOperatorDto
            {
                Id = e.Id,
                Name = e.Name,
                Phone =e.Phone
            }).ToList();

            return list;
        }

        public bool Add(UserOperatorDto userOperatorDto)
        {
            UserOperator userOperator = new UserOperator
            {
                Name = userOperatorDto.Name,
                Phone = userOperatorDto.Phone
            };
            try
            {
                _dbContext.UserOperators.Add(userOperator);
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
