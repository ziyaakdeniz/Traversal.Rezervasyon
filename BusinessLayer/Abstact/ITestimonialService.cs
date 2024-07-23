using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstact
{
    public interface ITestimonialService
    {
        Testimonial Add(Testimonial testimonial);
        Testimonial Update(Testimonial testimonial);
        bool Delete(int id);
        IQueryable<Testimonial> GetAll();
        IQueryable<Testimonial> GetAll(Expression<Func<Testimonial, bool>> predicate);
        Testimonial GetById(int id);
        Testimonial GetFirstOrDefault(Expression<Func<Testimonial, bool>> predicate);

    }
}
