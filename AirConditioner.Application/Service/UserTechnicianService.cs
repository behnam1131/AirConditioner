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
    public class UserTechnicianService : IUserTechnicianService
    {
        private readonly ApplicationDbContext _dbContext;
        public UserTechnicianService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<UserTechnicianDto> GetAll()
        {
            var list = _dbContext.UserTechnicians.Select(e => new UserTechnicianDto
            {
                Id = e.Id,
                Phone=e.Phone,
                Name = e.Name
            }).ToList();

            return list;
        }

        public bool Add(UserTechnicianDto userTechnicianDto)
        {
            UserTechnician userTechnician = new UserTechnician
            {
                Name = userTechnicianDto.Name,
                Phone = userTechnicianDto.Phone
            };
            try
            {
                _dbContext.UserTechnicians.Add(userTechnician);
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
