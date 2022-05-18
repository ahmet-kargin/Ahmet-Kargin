using BusReservation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Data.Abstract
{
    public interface ITicketRepository: IRepository<Ticket>
    {
        int GetCountBySeat(int directionId);
        List<int> GetSeat(int directionId);
        Ticket GetLastSave();
        int GetId();
        string GetDate(int id);
        string GetTime(int id);
    }
}
