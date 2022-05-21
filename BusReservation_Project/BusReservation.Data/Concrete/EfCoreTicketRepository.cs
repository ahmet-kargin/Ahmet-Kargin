using BusReservation.Data.Abstract;
using BusReservation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Data.Concrete
{
    public class EfCoreTicketRepository : EfCoreGenericRepository<Ticket,TicketContext>, ITicketRepository
    {
        public int GetCountBySeat(int directionId)
        {
            using (var context = new TicketContext())
            {
                return context.Tickets
                    .Where(i => i.DirectionId == directionId)
                    .Select(i => i.SeatNo)
                    .Count();
            }
        }

        public List<int> GetSeat(int directionId)
        {
            using (var context = new TicketContext())
            {
                var seat = context.Tickets
                    .Where(i => i.DirectionId == directionId)
                    .Select(i => i.SeatNo)
                    .ToList();

                return seat;
            }
        }

        public Ticket GetLastSave()
        {
            using (var context = new TicketContext())
            {
                var lastTicket = context.Tickets
                    .OrderByDescending(i => i.TicketId)
                    .FirstOrDefault();
                return lastTicket;
            }
        }

        public int GetId()
        {
            using (var context = new TicketContext())
            {
                var id = context.Tickets
                    .OrderByDescending(i => i.TicketId)
                    .Select(i => i.DirectionId)
                    .FirstOrDefault();
                return id;
            }
        }

        public DateTime GetDate(int id)
        {
            using (var context = new TicketContext())
            {
                var lastTicketDate = context.Directions
                    .Where(i => i.DirectionId == id)
                    .Select(i => i.Date)
                    .FirstOrDefault();

                return lastTicketDate;
            }
        }

        public string GetTime(int id)
        {
            throw new NotImplementedException();
        }
    }
}
