using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstact
{
    public interface INewslaterService
    {
        Newslater Add(Newslater newslater);
        Newslater Update(Newslater newslater);
        bool Delete(int id);
        IQueryable<Newslater> GetAll();
        IQueryable<Newslater> GetAll(Expression<Func<Newslater, bool>> predicate);
        Newslater GetById(int id);
        Newslater GetFirstOrDefault(Expression<Func<Newslater, bool>> predicate);
    }
}
