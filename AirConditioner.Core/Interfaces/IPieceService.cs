using AirConditioner.Core.Dtos;
using AirConditioner.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AirConditioner.Core.Interfaces
{
    public interface IPieceService
    {
        PieceDto GetById(int id);

        List<PieceDto> GetAll();
        
        bool Add(PieceDto pieceDto);
        bool Update(PieceDto pieceDto);


    }

}
