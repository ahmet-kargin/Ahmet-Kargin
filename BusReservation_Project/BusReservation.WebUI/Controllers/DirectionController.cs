using BusReservation.Business.Abstract;
using BusReservation.Entity;
using BusReservation.WebUI.Models.Direction;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservation.WebUI.Controllers
{
    public class DirectionController : Controller
    {
        #region private Member
        private readonly IDirectionService _directionService;
        private readonly ICityService _cityService;
        private readonly IChooseSeatService _chooseSeatService;

        public DirectionController(ICityService cityService, IDirectionService directionService, IChooseSeatService chooseSeatService)
        {
            _cityService = cityService;
            _directionService = directionService;
            _chooseSeatService = chooseSeatService;
        }
        #endregion

        #region List
        public IActionResult List()
        {
            var allDirections= _directionService.GetAll();
            return View(allDirections);
        }
        #endregion

        #region Add
        public IActionResult Add()
        {
            AddViewModel addViewModel = new AddViewModel();
            addViewModel.CitySelectList=new SelectList(_cityService.GetAll(), "CityName", "CityName");
            return View(addViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddViewModel model)
        {
            AddViewModel addViewModel = new AddViewModel();
            try
            {
                Direction direction = new Direction();
                direction.StartCity = model.StartCity;
                direction.FinishCity = model.FinishCity;
                direction.Date = model.Date;
                direction.Price = model.Price;
                direction.SeatTotalNumber = model.SeatTotalNumber;

                var newDirection= _directionService.Create(direction);

                if (model.SeatTotalNumber>0)
                {
                    for (int i = 1; i <= model.SeatTotalNumber; i++)
                    {

                        ChooseSeat chooseSeat = new ChooseSeat();
                        chooseSeat.DirectionId = direction.DirectionId;
                        chooseSeat.IsEmpty = true;
                        chooseSeat.Name = i.ToString();
                        _chooseSeatService.Create(chooseSeat);
                    }
                }

                return RedirectToAction("List");
            }
            catch (Exception)
            {
                addViewModel.CitySelectList = new SelectList(_cityService.GetAll(), "CityId", "CityName");
                ViewBag.Message = "Hata Oluştu.";
                return View(addViewModel);
            }
        }

        #endregion

        #region Seat List
        public IActionResult SeatList(int id)
        {
            SeatListViewModel model = new SeatListViewModel();
            try
            {
                var direction = _directionService.GetById(id);
                model.DirectionId = direction.DirectionId;
                model.StartCity = direction.StartCity;
                model.FinishCity = direction.FinishCity;
                model.Date = direction.Date;
                model.Price = direction.Price;
                model.SeatList = _chooseSeatService.GetChooseSeatsByDirectionId(model.DirectionId);
                return View(model);
            }
            catch (Exception ex)
            {
                var exx = ex;
                ViewBag.Error = "Hata Oluştu.";
                return View(model);
            }
        }
        #endregion
    }
}
