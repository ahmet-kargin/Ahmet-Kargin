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
    public class DirectionManager : IDirectionService
    {
        private IDirectionRepository _directionRepository;
        public DirectionManager(IDirectionRepository directionRepository)
        {
            _directionRepository = directionRepository;
        }
        public int Create(Direction entity)
        {
            return  _directionRepository.Create(entity);
        }

        public void Delete(Direction entity)
        {
            _directionRepository.Delete(entity);
        }

        public List<Direction> GetAll()
        {
            return _directionRepository.GetAll();
        }


        public string GetArrivalCity(string arrival)
        {
            return _directionRepository.GetArrivalCity(arrival);
        }

        public Direction GetById(int id)
        {
            return _directionRepository.GetById(id);
        }

        public string GetDepartureCity(string departure)
        {
            return _directionRepository.GetDepartureCity(departure);
        }

        public int GetDirectionByBslBts(string departureCity, string arrivalCity)
        {
            return _directionRepository.GetDirectionByBslBts(departureCity, arrivalCity);
        }

        public Direction GetDirectionDetails(int id)
        {
            return _directionRepository.GetDirectionDetails(id);
        }

        public List<Direction> GetTrip(string departure, string arrival,DateTime date)
        {
            return _directionRepository.GetTrip(departure, arrival,date);
        }

        public void Update(Direction entity)
        {
            _directionRepository.Update(entity);
        }
    }
}
