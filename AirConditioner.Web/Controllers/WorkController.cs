using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirConditioner.Core.Dtos;
using AirConditioner.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AirConditioner.Web.Controllers
{
    public class WorkController : BaseController
    {
        private readonly IWorkService _workService;
        public WorkController(IWorkService workService)
        {
            _workService = workService;

        }

        public IActionResult Index()
        {
            var list = _workService.GetAll();
            return View(list);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(WorkDto workDto)
        {

            var flag = _workService.Add(workDto);

            return RedirectToAction("Index");
        }
    }
}