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
    public class About2Service : IAbout2Service
    {
        private readonly IRepository<About2> _repository;

        public About2Service(IRepository<About2> repository)
        {
            _repository = repository;
        }

        public About2 Add(About2 about2)
        {
            return _repository.Add(about2);
        }

        public bool Delete(int about2Id)
        {
            _repository.Delete(about2Id);
            return true;
        }

        public IQueryable<About2> GetAll()
        {
            return _repository.GetAll();
        }

        public IQueryable<About2> GetAll(Expression<Func<About2, bool>> predicate)
        {
            return _repository.GetAll().Where(predicate);
        }

        public About2 GetById(int id)
        {
            return _repository.GetById(id);
        }

        public About2 GetFirstOrDefault(Expression<Func<About2, bool>> predicate)
        {
            return _repository.GetFirstOrDefault(predicate);
        }

        public About2 Update(About2 about2)
        {
            return _repository.Update(about2);
        }
    }
}
