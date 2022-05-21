using BusReservation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Data.Abstract
{
    public interface IChooseSeatRepository : IRepository<ChooseSeat>
    {
        List<ChooseSeat> GetChooseSeatsByDirectionId(int directionId);
    }
}
