using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirConditioner.Core.Dtos;
using AirConditioner.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AirConditioner.Web.Controllers
{
    public class CustomerController : BaseController
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;

        }

        public IActionResult Index()
        {
            //PagedResult<CustomerDto> list = _customerService.GetQuery().GetPaged(1,2);

            var list = _customerService.GetAll();


            return View(list);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(CustomerDto customerDto)
        {
            var customerDtoNew = _customerService.Add(customerDto);

            var customerJson = Newtonsoft.Json.JsonConvert.SerializeObject(customerDtoNew);
            TempData["customerJson"] = customerJson;


            return RedirectToAction("DisplayCustomerCode");

           
        }

        public IActionResult DisplayCustomerCode()
        {
           

                if (TempData["customerJson"] is string customerJson)
                {
                    var newCustomerJson = Newtonsoft.Json.JsonConvert.DeserializeObject<CustomerDto>(customerJson);
                    return View(newCustomerJson);
                }

                return RedirectToAction("Index");
            
        }
    }
}