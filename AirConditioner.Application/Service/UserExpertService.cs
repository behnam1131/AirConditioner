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
    public class UserExpertService : IUserExpertService
    {
        private readonly ApplicationDbContext _dbContext;
        public UserExpertService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<UserExpertDto> GetAll()
        {
            var list = _dbContext.UserExperts.Select(e => new UserExpertDto
            {
                Id = e.Id,
                Name = e.Name,
                Phone = e.Phone
            }).ToList();

            return list;
        }

        public bool Add(UserExpertDto userExpertDto)
        {
            UserExpert userExpert = new UserExpert
            {
                Name = userExpertDto.Name
            };
            try
            {
                _dbContext.UserExperts.Add(userExpert);
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
