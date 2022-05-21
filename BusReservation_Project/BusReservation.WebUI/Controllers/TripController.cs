using BusReservation.Business.Abstract;
using BusReservation.Entity;
using BusReservation.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservation.WebUI.Controllers
{
    public class TripController : Controller
    {
        private IDirectionService _directionService;
        private ITicketService _ticketService;
        public TripController(IDirectionService directionService, ITicketService ticketService)
        {
            this._directionService = directionService;
            this._ticketService = ticketService;
        }
        public IActionResult Details(int id)
        {
            Direction direction = _directionService.GetDirectionDetails(id);
            int directionTotalSeat = _ticketService.GetCountBySeat(id);
            List<int> soldSeats = _ticketService.GetSeat(id);
            var seats = new List<int>() { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,
            21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46};
            foreach (var item in soldSeats)
            {
                seats.Remove(item);
            }
            ViewBag.Number = directionTotalSeat;
            ViewBag.Seats = new SelectList(seats);
            if (direction==null)
            {
                return NotFound();
            }
            else
            {
                return View(direction);
            }
        }
        [HttpPost]
        public IActionResult Details(int directionId,double price,string departureCity,
            string arrivalCity, int seatNo, string passengerMail,
            string passengerTel,string passengerName, string passengerSurname)
        {
            var entity = new Ticket()
            {
                PassengerName = passengerName,
                PassengerSurname = passengerSurname,
                PassengerMail = passengerMail,
                //TicketDepartureCity = departureCity,
                //TicketArrivalCity = arrivalCity,
                SeatNo = seatNo,
                Price = price,
                DirectionId = directionId
            };
            //_directionService.Create(entity);
            return RedirectToAction("Basarili");
        }
        public IActionResult Successful()
        {
            Ticket newTicket = _ticketService.GetLastSave();
            int directionId = _ticketService.GetId();
            string directionTime = _ticketService.GetTime(directionId);
            string directionDate = _ticketService.GetDate(directionId);

            var ticketDirection = new TicketDirection()
            {
                Date = directionDate,
                Time = directionTime,
                Ticket = newTicket
            };
            return View(ticketDirection);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
