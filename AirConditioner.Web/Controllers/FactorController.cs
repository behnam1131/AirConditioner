using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirConditioner.Application.Service;
using AirConditioner.Core.Dtos;
using AirConditioner.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AirConditioner.Web.Controllers
{
    public class FactorController : BaseController
    {

        private readonly IAirConditionerModelService _airConditionerModelService; 
        private readonly IEngineVolumeService _engineVolumeService; 
        private readonly IUserExpertService _userExpertService; 
        private readonly IUserOperatorService _userOperatorService; 
        private readonly IUserTechnicianService _userTechnicianService; 
        private readonly IUserAssistantService _userAssistantService; 
        private readonly ICustomerService _customerService;
        private readonly IPieceService _pieceService;
        private readonly IWorkService _pieceWorkService;
        private readonly IFactorService _factorService;

        public FactorController(IAirConditionerModelService airConditionerModelService,
            IEngineVolumeService engineVolumeService,
            IUserExpertService userExpertService,
            IUserOperatorService userOperatorService,
            IUserTechnicianService userTechnicianService,
            IUserAssistantService userAssistantService,
            ICustomerService customerService,
            IPieceService pieceService,
            IWorkService workService,
            IFactorService factorService)
        {
            _airConditionerModelService = airConditionerModelService;
            _engineVolumeService = engineVolumeService;
            _userExpertService = userExpertService;
            _userOperatorService = userOperatorService;
            _userTechnicianService = userTechnicianService;
            _userAssistantService = userAssistantService;
            _customerService = customerService;
            _pieceService = pieceService;
            _pieceWorkService = workService;
            _factorService = factorService;
        }


        public IActionResult Index()
        {
            var list = _factorService.GetAll();
            return View(list);
        }

        public IActionResult Add()
        {
            ViewBag.AirConditionerModelList = new SelectList(_airConditionerModelService.GetAll(), "Id", "Name");
            ViewBag.EngineVolumeList = new SelectList(_engineVolumeService.GetAll(), "Id", "Name");
            ViewBag.UserExpertList = new SelectList(_userExpertService.GetAll(), "Id", "Name");
            ViewBag.UserOperatorList = new SelectList(_userOperatorService.GetAll(), "Id", "Name");
            ViewBag.UserTechnicianList = new SelectList(_userTechnicianService.GetAll(), "Id", "Name");
            ViewBag.UserAssistantList = new SelectList(_userAssistantService.GetAll(), "Id", "Name");
            ViewBag.CustomerList =_customerService.GetAll();

            ViewBag.PieceList = _pieceService.GetAll();
          


            return View();
        }

        [HttpPost]
        public IActionResult Add(FactorDto factorDto)
        {
            var factor = _factorService.Add(factorDto);


            var facorJson = Newtonsoft.Json.JsonConvert.SerializeObject(factor);
            TempData["factorNew"] = facorJson;
            

            return RedirectToAction("DisplayFactorCode");
        }

        public IActionResult DisplayFactorCode()
        {

            if (TempData["factorNew"] is string facorJson)
            {
                var newFacorJson = Newtonsoft.Json.JsonConvert.DeserializeObject<FactorDto>(facorJson);
                return View(newFacorJson);
            }
           
            return RedirectToAction("Index");
        }


        public JsonResult GetAllPiece()
        {           
            var PieceList = _pieceService.GetAll();
            return Json(PieceList);
        }

        public JsonResult GetAllWork()
        {
            var WorkList = _pieceWorkService.GetAll();
            return Json(WorkList);
        }
    }
}