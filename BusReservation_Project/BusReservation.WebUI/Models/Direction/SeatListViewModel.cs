using BusReservation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservation.WebUI.Models.Direction
{
    public class SeatListViewModel
    {
        public int DirectionId { get; set; }
        public List<ChooseSeat> SeatList { get; set; }
    }
}
