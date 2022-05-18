using BusReservation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Business.Abstract
{
    public interface IDirectionService
    {
        Direction GetById(int id);
        void Create(Direction entity);
        void Update(Direction entity);
        void Delete(Direction entity);

        List<Direction> GetAll();
        string GetDepartureCity(string departure);
        string GetArrivalCity(string arrival);
        List<Direction> GetTrip(string departure, string arrival);
        int GetDirectionByBslBts(string departureCity, string arrivalCity);
        Direction GetDirectionDetails(int id);
    }
}
