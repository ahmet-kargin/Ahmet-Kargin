using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservation.WebUI.Models.Direction
{
    public class AddViewModel
    {
        public string StartCity { get; set; }
        public string FinishCity { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public int SeatTotalNumber { get; set; }


        //select list
        public SelectList CitySelectList { get; set; }
    }
}
