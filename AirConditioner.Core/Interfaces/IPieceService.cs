using AirConditioner.Core.Dtos;
using AirConditioner.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AirConditioner.Core.Interfaces
{
    public interface IPieceService
    {
        Task<Piece> Find(int id);

        Task<List<PieceDto>> GetAsync(int count);
        List<PieceDto> GetAll();
        bool Add(PieceDto pieceDto);
        void Add(List<FactorPieceDto> factorPieceDtos);
    }

}
