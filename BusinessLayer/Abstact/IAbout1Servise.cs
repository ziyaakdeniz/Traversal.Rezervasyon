using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstact
{
    public interface IAbout1Servise
    {
        IQueryable<About1> GetAll();

        About1 Add(About1 about1);

        About1 Update(About1 about1);

        bool Delete(int about1Id);

        IQueryable<About1>GetAll(Expression<Func<About1, bool>> predicate);

        About1 GetById(int id);

        About1 GetFirstOrDefault(Expression<Func<About1, bool>> predicate);



    }
}
