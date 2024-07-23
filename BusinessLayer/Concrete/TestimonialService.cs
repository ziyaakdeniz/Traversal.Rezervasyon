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
    public class TestimonialService : ITestimonialService

    {
        private readonly IRepository<Testimonial> _repository;

        public TestimonialService(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public Testimonial Add(Testimonial testimonial)
        {
           return _repository.Add(testimonial); 
        }

        public bool Delete(int id)
        {
           _repository.Delete(id);
            return true;
        }

        public IQueryable<Testimonial> GetAll()
        {
           return _repository.GetAll();
        }

        public IQueryable<Testimonial> GetAll(Expression<Func<Testimonial, bool>> predicate)
        {
          return _repository.GetAll().Where(predicate);
        }

        public Testimonial GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Testimonial GetFirstOrDefault(Expression<Func<Testimonial, bool>> predicate)
        {
           return _repository.GetFirstOrDefault(predicate);
        }

        public Testimonial Update(Testimonial testimonial)
        {
           return _repository.Update(testimonial);
        }
    }
}
