using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Entity
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string TicketDepartureCity { get; set; }
        public string TicketArrivalCity { get; set; }
        public int SeatNo { get; set; }
        public int DirectionId { get; set; }
        public Direction Direction { get; set; }

    }
}
