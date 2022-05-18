using BusReservation.Data.Abstract;
using BusReservation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Data.Concrete
{
    public class EfCoreCityRepository : EfCoreGenericRepository<City, TicketContext>, ICityRepository
    {
        public string CityName()
        {
            throw new NotImplementedException();
        }
    }
}
