using BusReservation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Business.Abstract
{
    public interface ICityService
    {
        City GetById(int id);
        string CityName();
        void Create(City entity);
        void Update(City entity);
        void Delete(City entity);
        void Update(City entity, int[] cityIds);
        List<City> GetAll();
    }
}
