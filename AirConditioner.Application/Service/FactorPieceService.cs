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
    public class FactorPieceService : IFactorPieceService
    {
        private readonly ApplicationDbContext _dbContext;
        public FactorPieceService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<FactorPieceDto> GetAll()
        {
            var list = _dbContext.FactorPieces.Select(e => new FactorPieceDto
            {
                Id = e.Id,
                Comment = e.Comment,
                IsChange = e.IsChange,
                FactorId = e.FactorId,
                PriceOne = e.PriceOne,
                PriceTotal = e.PriceTotal,
                PieceId = e.PieceId,
                Value = e.Value,
                PieceName=e.PieceName
            }).ToList();

            return list;
        }

        public bool Add(FactorPieceDto factorPieceDto)
        {
            FactorPiece factorPiece = new FactorPiece
            {
                Id = factorPieceDto.Id,
                Comment = factorPieceDto.Comment,
                IsChange = factorPieceDto.IsChange,
                FactorId = factorPieceDto.FactorId,
                PriceOne = factorPieceDto.PriceOne,
                PriceTotal = factorPieceDto.PriceTotal,
                PieceId = factorPieceDto.PieceId,
                Value = factorPieceDto.Value,
                PieceName=factorPieceDto.PieceName
            };
            try
            {
                _dbContext.FactorPieces.Add(factorPiece);
                _dbContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Add(List<FactorPieceDto> factorPieceDtos)
        {
            var FactorPieces = factorPieceDtos.Select(e => new FactorPiece
            {
                Id = e.Id,
                Comment = e.Comment,
                IsChange = e.IsChange,
                FactorId = e.FactorId,
                PriceOne = e.PriceOne,
                PriceTotal = e.PriceOne * e.Value,
                PieceId = e.PieceId,
                Value = e.Value,
                PieceName=e.PieceName
            }).ToList();

            try
            {
                _dbContext.FactorPieces.AddRange(FactorPieces);
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
