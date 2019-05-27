using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirConditioner.Core.Dtos;
using AirConditioner.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AirConditioner.Web.Controllers
{
    public class UserAssistantController : BaseController
    {
        private readonly IUserAssistantService _userAssistantService;
        public UserAssistantController(IUserAssistantService userAssistantService)
        {
            _userAssistantService = userAssistantService;

        }

        public IActionResult Index()
        {
            var list = _userAssistantService.GetAll();
            return View(list);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(UserAssistantDto userAssistantDto)
        {

            var flag=_userAssistantService.Add(userAssistantDto);

            return RedirectToAction("Index");
        }
    }
}