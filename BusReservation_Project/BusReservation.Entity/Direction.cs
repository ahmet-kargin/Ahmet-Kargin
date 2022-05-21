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
        public string StartCity { get; set; }
        public string FinishCity { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public int SeatTotalNumber { get; set; }
        
    }
}
