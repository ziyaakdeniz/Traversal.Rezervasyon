using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstact
{
    public interface IDestinationService
    {
        Destination Add(Destination destination);   
        Destination Update(Destination destination);
        bool Delete(int id);
        IQueryable<Destination> GetAll();
        IQueryable<Destination>GetAll(Expression<Func<Destination, bool>> predicate);
        Destination GetById(int id);
        Destination GetFirstOrDefault(Expression<Func<Destination, bool>> predicate);

    }
}
