using BusReservation.Business.Abstract;
using BusReservation.Data.Abstract;
using BusReservation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Business.Concrete
{
    public class TicketManager : ITicketService
    {
        private ITicketRepository _ticketRepository;
        public void Create(Ticket entity)
        {
            _ticketRepository.Create(entity);
        }

        public void Delete(Ticket entity)
        {
            throw new NotImplementedException();
        }

        public List<Ticket> GetAll()
        {
            throw new NotImplementedException();
        }

        public Ticket GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int GetCountBySeat(int directionId)
        {
            throw new NotImplementedException();
        }

        public string GetDate(int id)
        {
            throw new NotImplementedException();
        }

        public int GetId()
        {
            throw new NotImplementedException();
        }

        public Ticket GetLastSave()
        {
            throw new NotImplementedException();
        }

        public List<int> GetSeat(int DirectionId)
        {
            throw new NotImplementedException();
        }

        public string GetTime(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Ticket entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Ticket entity, int[] ticketIds)
        {
            throw new NotImplementedException();
        }
    }
}
