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
    public class NewslaterService : INewslaterService
    {
        private readonly IRepository<Newslater> _newslaterRepository;

        public NewslaterService(IRepository<Newslater> newslaterRepository)
        {
            _newslaterRepository = newslaterRepository;
        }

        public Newslater Add(Newslater newslater)
        {
            return _newslaterRepository.Add(newslater);
        }

        public bool Delete(int id)
        {
          _newslaterRepository.Delete(id);
            return true;
        }

        public IQueryable<Newslater> GetAll()
        {
            return _newslaterRepository.GetAll();
        }

        public IQueryable<Newslater> GetAll(Expression<Func<Newslater, bool>> predicate)
        {
            return _newslaterRepository.GetAll().Where(predicate);
        }

        public Newslater GetById(int id)
        {
           return _newslaterRepository.GetById(id);
        }

        public Newslater GetFirstOrDefault(Expression<Func<Newslater, bool>> predicate)
        {
          return _newslaterRepository.GetFirstOrDefault(predicate);
        }

        public Newslater Update(Newslater newslater)
        {
            return _newslaterRepository.Update(newslater);
        }
    }
}
