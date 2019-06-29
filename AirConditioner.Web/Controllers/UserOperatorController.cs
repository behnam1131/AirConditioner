using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirConditioner.Core.Dtos;
using AirConditioner.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AirConditioner.Web.Controllers
{
    public class UserOperatorController : BaseController
    {
        private readonly IUserOperatorService _userOperatorService;
        public UserOperatorController(IUserOperatorService userOperatorService)
        {
            _userOperatorService = userOperatorService;

        }

        public IActionResult Index()
        {
            var list = _userOperatorService.GetAll();
            return View(list);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(UserOperatorDto userOperatorDto)
        {

            var flag = _userOperatorService.Add(userOperatorDto);

            return RedirectToAction("Index");
        }

        
    }
}