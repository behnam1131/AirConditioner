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
    public class AirConditionerModelService : IAirConditionerModelService
    {
        private readonly ApplicationDbContext _dbContext;
        public AirConditionerModelService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<AirConditionerModelDto> GetAll()
        {
            var list = _dbContext.AirConditionerModels.Select(e=>new AirConditionerModelDto
            {
                Id=e.Id,
                Name=e.Name
            }).ToList();

            return list;
        }

        public bool Add(AirConditionerModelDto airConditionerModelDto)
        {
            Core.Models.AirConditionerModel airConditionerModel = new Core.Models.AirConditionerModel
            {
                Name = airConditionerModelDto.Name
            };
            try
            {
                _dbContext.AirConditionerModels.Add(airConditionerModel);
                _dbContext.SaveChanges();
                return true;

            }catch(Exception ex)
            {
                return false;
            }            
        }       
    }
}
