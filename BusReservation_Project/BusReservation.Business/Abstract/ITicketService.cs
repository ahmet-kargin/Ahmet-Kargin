using BusReservation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Business.Abstract
{
    public interface ITicketService
    {
        Ticket GetById(int id);
        void Create(Ticket entity);
        void Update(Ticket entity);
        void Delete(Ticket entity);
        void Update(Ticket entity, int[] ticketIds);
        List<Ticket> GetAll();
        int GetCountBySeat(int directionId);
        List<int> GetSeat(int DirectionId);
        Ticket GetLastSave();
        int GetId();
        string GetDate(int id);
        string GetTime(int id);
    }
}
