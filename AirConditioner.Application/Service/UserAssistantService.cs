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
    public class UserAssistantService : IUserAssistantService
    {
        private readonly ApplicationDbContext _dbContext;
        public UserAssistantService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<UserAssistantDto> GetAll()
        {
            var list = _dbContext.UserAssistants.Select(e => new UserAssistantDto
            {
                Id = e.Id,
                Name = e.Name,
                Phone=e.Phone
            }).ToList();

            return list;
        }

        public bool Add(UserAssistantDto userAssistantDto)
        {
            UserAssistant userAssistant = new UserAssistant
            {
                Name = userAssistantDto.Name,
                Phone = userAssistantDto.Phone
            };
            try
            {
                _dbContext.UserAssistants.Add(userAssistant);
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
