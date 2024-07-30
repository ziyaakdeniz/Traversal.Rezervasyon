using BusinessLayer.Abstact;
using DataAccessLayer.Shared.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationService : IReservationService
    {
        private readonly IRepository<Reservation> _reservationRepository;

        public ReservationService(IRepository<Reservation> reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public Reservation Add(Reservation reservation)
        {
            return _reservationRepository.Add(reservation);
        }

        public bool Delete(int reservationId)
        {
            _reservationRepository.Delete(reservationId);
            return true;
        }

        public IQueryable<Reservation> GetAll()
        {
            return _reservationRepository.GetAll();
        }

        public IQueryable<Reservation> GetAll(Expression<Func<Reservation, bool>> predicate)
        {
            return _reservationRepository.GetAll().Where(predicate);
        }

        public Reservation GetById(int id)
        {
            return _reservationRepository.GetById(id);
        }

        public Reservation GetFirstOrDefault(Expression<Func<Reservation, bool>> predicate)
        {
            return _reservationRepository.GetFirstOrDefault(predicate);
        }

        public Reservation Update(Reservation reservation)
        {
            return _reservationRepository.Update(reservation);
        }
    }
}
