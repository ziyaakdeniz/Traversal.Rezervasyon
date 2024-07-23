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
    public class SubAboutService : ISubAboutService
    {
        private readonly IRepository<SubAbout> _subAboutRepository;

        public SubAboutService(IRepository<SubAbout> subAboutRepository)
        {
            _subAboutRepository = subAboutRepository;
        }

        public SubAbout Add(SubAbout subAbout)
        {
           return _subAboutRepository.Add(subAbout);
        }

        public bool Delete(int id)
        {
            _subAboutRepository.Delete(id);
            return true;
        }

        public IQueryable<SubAbout> GetAll()
        {
           return _subAboutRepository.GetAll();
        }

        public IQueryable<SubAbout> GetAll(Expression<Func<SubAbout, bool>> predicate)
        {
           return _subAboutRepository.GetAll().Where(predicate);
        }

        public SubAbout GetById(int id)
        {
           return _subAboutRepository.GetById(id);
        }

        public SubAbout GetFirstOrDefault(Expression<Func<SubAbout, bool>> predicate)
        {
           return _subAboutRepository.GetFirstOrDefault(predicate);
        }

        public SubAbout Update(SubAbout subAbout)
        {
            return _subAboutRepository.Update(subAbout);
        }
    }
}
