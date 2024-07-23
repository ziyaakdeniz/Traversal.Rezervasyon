using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstact
{
    public interface IGuideService
    {
        Guide Add(Guide guide);
        Guide Update(Guide guide);
        bool Delete(int id);
        IQueryable<Guide> GetAll();
        IQueryable<Guide> GetAll(Expression<Func<Guide, bool>> predicate);
        Guide GetById(int id);
        Guide GetFirstOrDefault(Expression<Func<Guide, bool>> predicate);

    }
}
