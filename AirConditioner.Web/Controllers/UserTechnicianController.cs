using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirConditioner.Core.Dtos;
using AirConditioner.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AirConditioner.Web.Controllers
{
    public class UserTechnicianController : BaseController
    {
        private readonly IUserTechnicianService _userTechnicianService;
        public UserTechnicianController(IUserTechnicianService userTechnicianService)
        {
            _userTechnicianService = userTechnicianService;

        }

        public IActionResult Index()
        {
            var list = _userTechnicianService.GetAll();
            return View(list);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(UserTechnicianDto userTechnicianDto)
        {

            var flag = _userTechnicianService.Add(userTechnicianDto);

            return RedirectToAction("Index");
        }
    }
}