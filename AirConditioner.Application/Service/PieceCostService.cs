using AirConditioner.Core.Dtos;
using AirConditioner.Core.Interfaces;
using AirConditioner.Core.Models;
using AirConditioner.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirConditioner.Application.Service
{
    public class PieceCostService : IPieceCostService
    {
        private readonly ApplicationDbContext _dbContext;
        public PieceCostService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public PieceCostDto GetLast(int pieceId)
        {
            var PieceCostDto = _dbContext.PieceCosts
                .Where(e => e.PieceId == pieceId)
                .Where(e => e.ToDateTime == null)
                .Select(e => new PieceCostDto
                {
                    Id=e.Id,
                    FromDateTime=e.FromDateTime,
                    ToDateTime=e.ToDateTime,
                    PieceId=e.PieceId,
                    PercentColleague=e.PercentColleague,
                    PercentCustomer=e.PercentCustomer,
                    Price=e.Price
                }).LastOrDefault();

            return PieceCostDto;

        }

        public List<PieceCostDto> GetAll(int pieceId)
        {
            var PieceCostDto = _dbContext.PieceCosts
                .Where(e => e.PieceId == pieceId)
                .Select(e => new PieceCostDto
                {
                    Id = e.Id,
                    FromDateTime = e.FromDateTime,
                    ToDateTime = e.ToDateTime,
                    PieceId = e.PieceId,
                    PercentColleague = e.PercentColleague,
                    PercentCustomer = e.PercentCustomer,
                    Price = e.Price
                }).ToList();

            return PieceCostDto;

        }

        public bool Add(double price,int PercentCustomer,int PercentColleague, int pieceId)
        {
            var DateTimeNow = DateTime.Now;

            var pieceCost = _dbContext.PieceCosts
                .Where(e => e.PieceId == pieceId)
                .Where(e => e.ToDateTime == null)
                .Select(e => new PieceCost
                {
                    Id = e.Id,
                    FromDateTime = e.FromDateTime,
                    ToDateTime = e.ToDateTime,
                    PieceId = e.PieceId,
                    PercentColleague = e.PercentColleague,
                    PercentCustomer = e.PercentCustomer,
                    Price = e.Price
                }).LastOrDefault();
            if (pieceCost != null)
            {
                pieceCost.ToDateTime = DateTimeNow;
            }


            PieceCost PieceCostNew = new PieceCost()
            {               
                FromDateTime = DateTimeNow,
                ToDateTime =null,
                PieceId = pieceId,
                PercentColleague = PercentColleague,
                PercentCustomer = PercentCustomer,
                Price = price
            };
            try
            {
                _dbContext.PieceCosts.Add(PieceCostNew);
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
