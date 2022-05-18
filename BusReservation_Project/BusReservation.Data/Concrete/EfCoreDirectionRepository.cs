using BusReservation.Data.Abstract;
using BusReservation.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Data.Concrete
{
    public class EfCoreDirectionRepository : EfCoreGenericRepository<Direction, TicketContext>, IDirectionRepository
    {
        public string GetArrivalCity(string arrival)
        {
            using (var context = new TicketContext())
            {
                var arrivalCity = context.Cities
                    .Where(i => i.CityId == Convert.ToInt32(arrival))
                    .Select(i => i.CityName)
                    .ToList();
                return arrivalCity[0];
            }
        }

        public string GetDepartureCity(string departure)
        {
            using (var context = new TicketContext())
            {
                var departureCity = context.Cities
                    .Where(i => i.CityId == Convert.ToInt32(departure))
                    .Select(i => i.CityName)
                    .ToList();
                return departureCity[0];
            }
        }

        public int GetDirectionByBslBts(string departure, string arrival)
        {
            throw new NotImplementedException();
        }

        public Direction GetDirectionDetails(int id)
        {
            using (var context = new TicketContext())
            {
                return context.Directions
                    .Where(i => i.DirectionId == id)
                    .AsNoTracking()
                    .FirstOrDefault();
            }
        }

        public List<Direction> GetTrip(string departure, string arrival)
        {
            using (var context = new TicketContext())
            {
                var nrdn = context.Cities
                    .Where(i => i.CityId == Convert.ToInt32(departure))
                    .Select(i => i.CityName)
                    .ToList();
                var nry = context.Cities
                    .Where(i => i.CityId == Convert.ToInt32(arrival))
                    .Select(i => i.CityName)
                    .ToList();
                var guzergahs = context.Directions
                    .FromSqlRaw($"select * from Guzergahs where ((Baslangic='{nrdn[0]}') and (Bitis='{nry[0]}' )) ")
                    .ToList();

                return guzergahs;

            }
        }
    }
}
