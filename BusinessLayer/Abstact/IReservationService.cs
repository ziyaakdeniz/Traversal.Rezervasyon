using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstact
{
    public interface IReservationService
    {
        IQueryable<Reservation> GetAll();

        Reservation Add(Reservation reservation);

        Reservation Update(Reservation reservation);

        bool Delete(int reservationId);

        IQueryable<Reservation> GetAll(Expression<Func<Reservation, bool>> predicate);

        Reservation GetById(int id);

        Reservation GetFirstOrDefault(Expression<Func<Reservation, bool>> predicate);
    }
}
