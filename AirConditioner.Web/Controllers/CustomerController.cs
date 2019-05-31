using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirConditioner.Core.Dtos;
using AirConditioner.Core.Interfaces;
using AirConditioner.Helper;
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
            var flag = _customerService.Add(customerDto);

            return RedirectToAction("Index");
        }
    }
}