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
    public class GuideService : IGuideService
    {
        private readonly IRepository<Guide> _guideRepository;

        public GuideService(IRepository<Guide> guideRepository)
        {
            _guideRepository = guideRepository;
        }

        public Guide Add(Guide guide)
        {
          return _guideRepository.Add(guide);
        }

        public bool Delete(int id)
        {
            _guideRepository.Delete(id);
            return true;
        }

        public IQueryable<Guide> GetAll()
        {
           return _guideRepository.GetAll();
        }

        public IQueryable<Guide> GetAll(Expression<Func<Guide, bool>> predicate)
        {
           return _guideRepository.GetAll().Where(predicate);
        }

        public Guide GetById(int id)
        {
           return _guideRepository.GetById(id);
        }

        public Guide GetFirstOrDefault(Expression<Func<Guide, bool>> predicate)
        {
           return _guideRepository.GetFirstOrDefault(predicate);
        }

        public Guide Update(Guide guide)
        {
           return _guideRepository.Update(guide);
        }
    }
}
