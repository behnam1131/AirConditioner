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
    public class EngineVolumeService : IEngineVolumeService

    {
        private readonly ApplicationDbContext _dbContext;
        public EngineVolumeService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<EngineVolumeDto> GetAll()
        {
            var list = _dbContext.EngineVolumes.Select(e => new EngineVolumeDto
            {
                Id = e.Id,
                Name = e.Name
            }).ToList();

            return list;
        }

        public bool Add(EngineVolumeDto engineVolumeDto)
        {
            EngineVolume engineVolume = new EngineVolume
            {
                Name = engineVolumeDto.Name
            };
            try
            {
                _dbContext.EngineVolumes.Add(engineVolume);
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
