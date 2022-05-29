using BusReservation.Business.Abstract;
using BusReservation.Entity;
using BusReservation.WebUI.Models;
using BusReservation.WebUI.Models.Ticket;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservation.WebUI.Controllers
{
    public class TicketController : Controller
    {
        private readonly IDirectionService _directionService;
        private readonly IChooseSeatService _chooseSeatService;
        private readonly ITicketService _ticketService;

        public TicketController(IDirectionService directionService, IChooseSeatService chooseSeatService, ITicketService ticketService)
        {
            _directionService = directionService;
            _chooseSeatService = chooseSeatService;
            _ticketService = ticketService;
        }


        public IActionResult Add(int id)
        {
            AddViewModel model = new AddViewModel();
            var chooseSeat = _chooseSeatService.GetById(id);
            var direction = _directionService.GetById(chooseSeat.DirectionId);
            model.DirectionId = direction.DirectionId;
            model.StartCity = direction.StartCity;
            model.FinishCity = direction.FinishCity;
            model.Date = direction.Date;
            model.SeatName = chooseSeat.Name;
            model.Price = direction.Price;
            model.ChooseSeatId = id;
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(AddViewModel model)
        {
            try
            {
                Ticket ticket = new Ticket();
                ticket.PassengerName = model.PassengerName;
                ticket.PassengerSurname = model.PassengerSurname;
                ticket.PassengerMail = model.Mail;
                ticket.PassengerTel = model.Tel;
                ticket.SeatNo = Convert.ToInt32(model.SeatName);
                ticket.Price = model.Price;
                ticket.DirectionId = model.DirectionId;
                _ticketService.Create(ticket);
                var chooseSeat = _chooseSeatService.GetById(model.ChooseSeatId);
                chooseSeat.IsEmpty = false;
                _chooseSeatService.Update(chooseSeat);
            }
            catch(Exception ex)
            {
                var ex1 = ex;
                ViewBag.Error = "ERROR";
                return View(model);
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult TicketDetails()
        {
            Ticket lastTicket = _ticketService.GetLastSave();
            int routeId = _ticketService.GetId();
            string Time = _ticketService.GetTime(routeId);
            string Date = _ticketService.GetDate(routeId);

            var routeTicket = new TicketDirection()
            {
                Date = Date,
                Time = Time,
                Ticket = lastTicket
            };
            return View(routeTicket);
        }
        
        
    }
}
