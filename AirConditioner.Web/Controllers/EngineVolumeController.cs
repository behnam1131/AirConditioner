using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirConditioner.Core.Dtos;
using AirConditioner.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AirConditioner.Web.Controllers
{
    public class EngineVolumeController : BaseController
    {
        private readonly IEngineVolumeService _engineVolumeService;
        public EngineVolumeController(IEngineVolumeService engineVolumeService)
        {
            _engineVolumeService = engineVolumeService;

        }

        public IActionResult Index()
        {
            var list = _engineVolumeService.GetAll();
            return View(list);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(EngineVolumeDto engineVolumeDto)
        {

            var f = _engineVolumeService.Add(engineVolumeDto);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index"); 
            }
            var engineVolume = _engineVolumeService.GetById((int)id);
            if (engineVolume == null)
            {
                return RedirectToAction("Index");
            }
            return View(engineVolume);
        }

        [HttpPost]
        public IActionResult Edit(EngineVolumeDto engineVolumeDto)
        {
            var engineVolume = _engineVolumeService.Edit(engineVolumeDto);
            return RedirectToAction("Index");
        }
    }
}