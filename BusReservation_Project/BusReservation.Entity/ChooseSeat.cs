using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Entity
{
    public class ChooseSeat
    {
        public int ChooseSeatId { get; set; }
        public int DirectionId { get; set; }
        public Direction Direction { get; set; }
        public string Name { get; set; }
        public bool IsEmpty { get; set; }
      
    }
}
