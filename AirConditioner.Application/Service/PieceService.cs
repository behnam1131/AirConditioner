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
        private readonly IPieceCostService _pieceCostService;
        public PieceService(ApplicationDbContext dbContext, IPieceCostService pieceCostService)
        {
            _dbContext = dbContext;
            _pieceCostService = pieceCostService;
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
                    Price= e.PieceCosts.Where(q => q.FromDateTime == e.PieceCosts.Max(w => w.FromDateTime)).FirstOrDefault().Price,
                    PercentColleague =e.PieceCosts.Where(q=>q.FromDateTime==e.PieceCosts.Max(w=>w.FromDateTime)).FirstOrDefault().PercentColleague,
                    PercentCustomer= e.PieceCosts.Where(q => q.FromDateTime == e.PieceCosts.Max(w => w.FromDateTime)).FirstOrDefault().PercentCustomer,
                }).ToList();

            return list;
        }       

        public bool Add(PieceDto pieceDto)
        {
            var dateNow = DateTime.Now;
            
            Piece piece = new Piece()
            {
                Id = pieceDto.Id,
                Name = pieceDto.Name,
            };
            try
            {
                _dbContext.Pieces.Add(piece);
                _dbContext.SaveChanges();
                _pieceCostService.Add(pieceDto.Price, pieceDto.PercentCustomer, pieceDto.PercentColleague, piece.Id);
                
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
                _dbContext.SaveChanges();
                _pieceCostService.Add(pieceDto.Price, pieceDto.PercentCustomer, pieceDto.PercentColleague, piece.Id);               

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }            
        }       
    }
}