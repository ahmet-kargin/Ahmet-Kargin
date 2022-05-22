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
        public string StartCity { get; set; }
        public string FinishCity { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public List<ChooseSeat> SeatList { get; set; }
    }
}
