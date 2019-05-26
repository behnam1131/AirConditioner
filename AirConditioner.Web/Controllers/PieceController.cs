using AirConditioner.Core.Dtos;
using AirConditioner.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AirConditioner.Web.Controllers
{
    public class PieceController : Controller
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

        //public async Task<IActionResult> Index()
        //{
        //    var list = await _pieceService.GetAllAsync();


        //    return View(list);

        //    //return Json(_timeManager.Current);
        //}





    }
}