using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirConditioner.Core.Dtos;
using AirConditioner.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AirConditioner.Web.Controllers
{
    public class AirConditionerModelController : BaseController
    {
        private readonly IAirConditionerModelService _airConditionerModelService;
        public AirConditionerModelController(IAirConditionerModelService airConditionerModelService)
        {
            _airConditionerModelService = airConditionerModelService;

        }

        public IActionResult Index()
        {
            var list = _airConditionerModelService.GetAll();
            return View(list);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AirConditionerModelDto airConditionerModelDto)
        {

            var f = _airConditionerModelService.Add(airConditionerModelDto);

            return RedirectToAction("Index");
        }
    }
}