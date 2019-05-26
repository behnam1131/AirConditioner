using AirConditioner.Core.Dtos;
using AirConditioner.Core.Interfaces;
using AirConditioner.Core.Models;
using AirConditioner.Data;
using System;

namespace AirConditioner.Application.Service
{
    public class PiecePriceService : IPiecePriceService
    {
        private readonly ApplicationDbContext _dbContext;
        public PiecePriceService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(double price,int pieceId)
        {
            PiecePrice piecePrice = new PiecePrice()
            {
                Price = price,
                PieceId= pieceId,
                ChangeDateTime = DateTime.Now,
                Time = DateTime.Now.ToShortTimeString()
            };
            try
            {
                _dbContext.PiecePrices.Add(piecePrice);
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
