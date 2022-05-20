using BusReservation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservation.WebUI.Models
{
    public class TicketDirection
    {
        public List<BusReservation.Entity.Ticket> Tickets { get; set; }
        public List<Direction> Directions { get; set; }
        public List<City> Cities { get; set; }
        public Direction NewDirection { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public Ticket Ticket { get; set; }
    }
}
