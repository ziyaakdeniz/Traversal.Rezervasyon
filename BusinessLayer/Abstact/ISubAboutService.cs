using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstact
{
    public interface ISubAboutService
    {
        SubAbout Add(SubAbout subAbout);
        SubAbout Update(SubAbout subAbout);
        bool Delete(int id);
        IQueryable<SubAbout> GetAll();
        IQueryable<SubAbout> GetAll(Expression<Func<SubAbout, bool>> predicate);
        SubAbout GetById(int id);
        SubAbout GetFirstOrDefault(Expression<Func<SubAbout, bool>> predicate);
    }

}
