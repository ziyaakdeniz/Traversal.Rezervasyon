using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstact
{
    public interface IAbout2Service
    {
        IQueryable<About2> GetAll();

        About2 Add(About2 about2);

        About2 Update(About2 about2);

        bool Delete(int about2Id);

        IQueryable<About2> GetAll(Expression<Func<About2, bool>> predicate);

        About2 GetById(int id);

        About2 GetFirstOrDefault(Expression<Func<About2, bool>> predicate);
    }
}
