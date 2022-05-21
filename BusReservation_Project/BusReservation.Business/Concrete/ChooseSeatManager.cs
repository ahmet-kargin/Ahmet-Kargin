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
    public class ChooseSeatManager : IChooseSeatService
    {
        private IChooseSeatRepository _chooseSeatRepository;
        public ChooseSeatManager(IChooseSeatRepository chooseSeatRepository)
        {
            _chooseSeatRepository = chooseSeatRepository;
        }
        public int Create(ChooseSeat entity)
        {
           return _chooseSeatRepository.Create(entity);
        }

        public void Delete(ChooseSeat entity)
        {
            _chooseSeatRepository.Delete(entity);
        }

        public List<ChooseSeat> GetAll()
        {
            return _chooseSeatRepository.GetAll();
        }

        public ChooseSeat GetById(int id)
        {
            return _chooseSeatRepository.GetById(id);
        }

        public void Update(ChooseSeat entity)
        {
            _chooseSeatRepository.Update(entity);
        }
        public List<ChooseSeat> GetChooseSeatsByDirectionId(int directionId)
        {
           return _chooseSeatRepository.GetChooseSeatsByDirectionId(directionId);
        }



    }
}
