using AirConditioner.Core.Dtos;
using AirConditioner.Core.Interfaces;
using AirConditioner.Core.Models;
using AirConditioner.Data;
using System;

namespace AirConditioner.Application.Service
{
    public class PiecePercentService : IPiecePercentService
    {
        private readonly ApplicationDbContext _dbContext;
        public PiecePercentService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        
        public bool Add(int Percent, int pieceId)
        {
            PiecePercent piecePercent = new PiecePercent()
            {
                Percent = Percent,
                PieceId=pieceId,
                ChangeDateTime = DateTime.Now,
                Time = DateTime.Now.ToShortTimeString()
            };
            try
            {
                _dbContext.piecePercents.Add(piecePercent);
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
