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
    public class EfCoreChooseSeatRepository : EfCoreGenericRepository<ChooseSeat, TicketContext>, IChooseSeatRepository
    {
        public List<ChooseSeat> GetChooseSeatsByDirectionId(int directionId)
        {
            using (var context = new TicketContext())
            {
                var seats = context.ChooseSeats
                    .FromSqlRaw($"select * from ChooseSeat where ((DirectionId='{directionId}'))")
                    .ToList();

                return seats;
            }
        }
    }
}
