using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservation.WebUI.Models.Ticket
{
    public class TicketListViewModel
    {
        public int ChooseSeatId { get; set; }
        public int DirectionId { get; set; }
        public string StartCity { get; set; }
        public string FinishCity { get; set; }
        public string SeatName { get; set; }
        public DateTime Date { get; set; }
        public string PassengerName { get; set; }
        public string PassengerSurname { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public double Price { get; set; }
    }
}
