using AirConditioner.Core.Dtos;
using AirConditioner.Core.Interfaces;
using AirConditioner.Core.Models;
using AirConditioner.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirConditioner.Application.Service
{
    public class FactorWorkService : IFactorWorkService
    {
        private readonly ApplicationDbContext _dbContext;
        public FactorWorkService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<FactorWorkDto> GetAll()
        {
            var list = _dbContext.FactorWorks.Select(e => new FactorWorkDto
            {
                Id = e.Id,
                Comment=e.Comment,
                Price=e.Price,
                WorkId=e.WorkId,
                WorkName=e.Work.Name
            }).ToList();

            return list;
        }

        public bool Add(FactorWorkDto factorWorkDto)
        {
            FactorWork factorWork = new FactorWork
            {
                Comment= factorWorkDto.Comment,
                Price= factorWorkDto.Price,
                WorkId= factorWorkDto.WorkId,                
            };
            try
            {
                _dbContext.FactorWorks.Add(factorWork);
                _dbContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Add(List<FactorWorkDto> factorWorkDtos)
        {
            List<FactorWork> factorWorks = factorWorkDtos.Select(factorWorkDto => new FactorWork()
            {
                Comment = factorWorkDto.Comment,
                Price = factorWorkDto.Price,
                FactorId=factorWorkDto.FactorId,
                WorkId = factorWorkDto.WorkId,
            }).ToList();
            try
            {
                _dbContext.FactorWorks.AddRange(factorWorks);
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
