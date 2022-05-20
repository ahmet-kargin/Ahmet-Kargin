using BusReservation.Business.Abstract;
using BusReservation.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservation.WebUI.Controllers
{
    public class UserController:Controller
    {
        private ITicketService _ticketService;
        public UserController(ITicketService ticketService)
        {
            this._ticketService = ticketService;
        }
        public IActionResult AdminList()
        {
            return View(new TicketDirection()
            {
                Tickets = _ticketService.GetAll()
            }) ;
        }
        public IActionResult CancelTicket(int ticketId)
        {
            var ticket = _ticketService.GetById(ticketId);
            if (ticket != null)
            {
                _ticketService.Delete(ticket);
            }
            return RedirectToAction("AdminList");
        }
    }
}
