using BusReservation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Data.Abstract
{
    public interface IDirectionRepository:IRepository<Direction>
    {
        string GetDepartureCity(string departure);
        string GetArrivalCity(string arrival);
        List<Direction> GetTrip(string departure, string arrival);
        int GetDirectionByBslBts(string departure, string arrival);
        Direction GetDirectionDetails(int id);
    }
}
