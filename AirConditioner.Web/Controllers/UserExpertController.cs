using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirConditioner.Core.Dtos;
using AirConditioner.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AirConditioner.Web.Controllers
{
    public class UserExpertController : Controller
    {
        private readonly IUserExpertService _userExpertService;
        public UserExpertController(IUserExpertService userExpertService)
        {
            _userExpertService = userExpertService;

        }

        public IActionResult Index()
        {
            var list = _userExpertService.GetAll();
            return View(list);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(UserExpertDto userExpertDto)
        {

            var flag = _userExpertService.Add(userExpertDto);

            return RedirectToAction("Index");
        }
    }
}