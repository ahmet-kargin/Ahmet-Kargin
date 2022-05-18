using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Entity
{
    public class Direction
    {
        public int DirectionId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public double Price { get; set; }
        public List<Ticket> Tickets { get; set; }
       
    }
}
