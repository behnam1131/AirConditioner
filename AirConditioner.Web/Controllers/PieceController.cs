using AirConditioner.Core.Dtos;
using AirConditioner.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AirConditioner.Web.Controllers
{
    public class PieceController : BaseController
    {
        private readonly IPieceService _pieceService;
        //private readonly ITimeManager _timeManager;

        public PieceController(IPieceService pieceService, ITimeManager timeManager)
        {
            _pieceService = pieceService;
            //_timeManager = timeManager;
        }

        public IActionResult Index()
        {
            var list = _pieceService.GetAll();

            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PieceDto pieceDto)
        {
            _pieceService.Add(pieceDto);
            return View();
        }

        public IActionResult Edit(int id)
        {
            var piece=_pieceService.GetById(id);
            return View(piece);
        }

        [HttpPost]
        public IActionResult Edit(PieceDto pieceDto)
        {
            _pieceService.Update(pieceDto);


            return RedirectToAction("Index", "Piece");
        }





    }
}