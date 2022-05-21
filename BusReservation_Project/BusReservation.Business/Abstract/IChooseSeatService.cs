using BusReservation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Business.Abstract
{
    public interface IChooseSeatService
    {
        ChooseSeat GetById(int id);
      
        int Create(ChooseSeat entity);
        void Update(ChooseSeat entity);
        void Delete(ChooseSeat entity);
        List<ChooseSeat> GetAll();
        List<ChooseSeat> GetChooseSeatsByDirectionId(int directionId);
    }
}
