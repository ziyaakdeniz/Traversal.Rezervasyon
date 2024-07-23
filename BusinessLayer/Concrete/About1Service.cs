using BusinessLayer.Abstact;
using DataAccessLayer.Shared.Abstract;
using DataAccessLayer.Shared.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class About1Service : IAbout1Servise
    {
        private readonly IRepository<About1> _repo;

        public About1Service(IRepository<About1> repo)
        {
            _repo = repo;
        }

        public About1 Add(About1 about1)
        {
           return _repo.Add(about1);
        }

        public bool Delete(int about1Id)
        {
          _repo.Delete(about1Id);
            return true;
        }

        public IQueryable<About1> GetAll()
        {
            return _repo.GetAll();
        }

        public IQueryable<About1> GetAll(Expression<Func<About1, bool>> predicate)
        {
            return _repo.GetAll().Where(predicate);
        }

        public About1 GetById(int id)
        {
           return _repo.GetById(id);
        }

        public About1 GetFirstOrDefault(Expression<Func<About1, bool>> predicate)
        {
            return _repo.GetFirstOrDefault(predicate);
        }

        public About1 Update(About1 about1)
        {
           return _repo.Update(about1);
        }
    }
}
