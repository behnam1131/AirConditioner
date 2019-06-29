using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirConditioner.Core.Interfaces;
using AirConditioner.Helper;
using Microsoft.AspNetCore.Mvc;

namespace AirConditioner.Web.Controllers
{
    public class UserFactorController : Controller
    {

        private readonly IUserOperatorService _userOperatorService;
        private readonly IUserAssistantService _userAssistantService;
        private readonly IUserExpertService _userExpertService;
        private readonly IUserTechnicianService _userTechnicianService;
        private readonly IFactorService _factorService;
        public UserFactorController(IUserOperatorService userOperatorService, IUserAssistantService userAssistantService,
          IUserExpertService userExpertService, IUserTechnicianService userTechnicianService,
          IFactorService factorService)
        {
            _userOperatorService = userOperatorService;
            _userAssistantService = userAssistantService;
            _userExpertService = userExpertService;
            _userTechnicianService = userTechnicianService;
            _factorService = factorService;

        }
    

        public IActionResult Index()
        {
            return View();
        }


        public JsonResult GetUser(int index)
        {
            object items;
            switch (index)
            {
                case (int)Actor.UserAssistant:
                    items = _userAssistantService.GetAll();
                    return Json(items);                    
                case (int)Actor.UserExpert:
                    items = _userExpertService.GetAll();
                    return Json(items);
                case (int)Actor.UserOperator:
                    items = _userOperatorService.GetAll();
                    return Json(items);
                case (int)Actor.UserTechnician:
                    items = _userTechnicianService.GetAll();
                    return Json(items);
            }


            return Json(null);
        }


        public JsonResult GetUserFactor(int actorId, int userId,string fromDate,string toDate)
        {
            var factors = _factorService.GetUserFactors((Actor)actorId, userId, fromDate, toDate);
            return Json(factors);
        }
    }
}