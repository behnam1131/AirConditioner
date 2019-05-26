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
    public class WorkService : IWorkService
    {
        private readonly ApplicationDbContext _dbContext;
        public WorkService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<WorkDto> GetAll()
        {
            var list = _dbContext.Works.Select(e => new WorkDto
            {
                Id = e.Id,
                Name = e.Name
            }).ToList();

            return list;
        }

        public bool Add(WorkDto workDto)
        {
            Work work = new Work
            {
                Name = workDto.Name
            };
            try
            {
                _dbContext.Works.Add(work);
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
