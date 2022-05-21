﻿using BusReservation.Business.Abstract;
using BusReservation.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservation.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICityService _cityService;
        private readonly IDirectionService _directionService;

        public HomeController(ICityService cityService, IDirectionService directionService )
        {
            _cityService = cityService;
            _directionService = directionService;
        }

        public IActionResult Index(string departureCity, string arrivalCity,DateTime date)
        {
            if (departureCity==null || arrivalCity==null||departureCity==arrivalCity || date ==null)
            {
                var cityModel = new TicketDirection()
                {
                    Cities = _cityService.GetAll(),
                    Directions = null
                };
                ViewBag.Cities = new SelectList(cityModel.Cities, "CityName", "CityName");
                return View(cityModel);
            }
            else
            {
                var cityModel = new TicketDirection()
                {
                    Cities=_cityService.GetAll(),
                    Directions=_directionService.GetTrip(departureCity,arrivalCity,date)
                };
                ViewBag.DepartureCity = departureCity;
                ViewBag.ArrivalCity = arrivalCity;
                ViewBag.Cities = new SelectList(cityModel.Cities, "CityName", "CityName");
                return View(cityModel);
            }

        }
        public IActionResult Contact()
        {
            ViewData["title"] = "Contact : ";
            return View();
        }
    }
}
