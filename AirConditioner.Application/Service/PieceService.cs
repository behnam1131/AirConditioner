using AirConditioner.Core.Dtos;
using AirConditioner.Core.Interfaces;
using AirConditioner.Core.Models;
using AirConditioner.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirConditioner.Application.Service
{
    public class PieceService : IPieceService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IPiecePercentService _piecePercenService;
        private readonly IPiecePriceService _piecePriceService;
        public PieceService(ApplicationDbContext dbContext, IPiecePriceService piecePriceService, IPiecePercentService piecePercenService)
        {
            _dbContext = dbContext;
            _piecePercenService = piecePercenService;
            _piecePriceService = piecePriceService;
        }

        public async Task<Piece> Find(int id)
        {
            var found = await _dbContext.Pieces.FindAsync(id);

            return found;
        }

        public List<PieceDto> GetAll()
        {
            var list = _dbContext.Pieces.OrderByDescending(e => e.Id)
                .Select(e => new PieceDto
                {
                    Id = e.Id,
                    Name =e.Name,
                    Percent=e.Percent,
                    Price=e.Price
                }).ToList();

            return list;
        }

        public async Task<List<PieceDto>> GetAsync(int count)
        {
            var list = await _dbContext.Pieces.OrderByDescending(e=>e.Id)
                .Select(e=> new PieceDto
                {
                    Id = e.Id,
                    Name = e.Name,
                    Percent = e.Percent,
                    Price = e.Price
                })
                .Take(count)
                .ToListAsync();

            return list;
        }

        public bool Add(PieceDto pieceDto)
        {
            Piece piece = new Piece()
            {
                Id = pieceDto.Id,
                Name = pieceDto.Name,
                Percent = pieceDto.Percent,
                Price = pieceDto.Price
            };
            try
            {
                _dbContext.Pieces.Add(piece);
                _dbContext.SaveChanges();

                _piecePercenService.Add(piece.Percent, piece.Id);
                _piecePriceService.Add(piece.Price, piece.Id);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(PieceDto pieceDto)
        {
            Piece piece = new Piece()
            { 
                Id= pieceDto.Id,               
            };

            try
            {
                _dbContext.Pieces.Attach(piece);

                piece.Percent = pieceDto.Percent;
                piece.Price = pieceDto.Price;

                _dbContext.SaveChanges();              

                _piecePercenService.Add(piece.Percent, piece.Id);
                _piecePriceService.Add(piece.Percent, piece.Id);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }            
        }

        public void Add(List<FactorPieceDto> factorPieceDtos)
        {
            throw new NotImplementedException();
        }
    }
}