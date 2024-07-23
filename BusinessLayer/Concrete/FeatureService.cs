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
    public class FeatureService : IFeatureService
    {
        private readonly IRepository<Feature> _repository;

        public FeatureService(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public Feature Add(Feature feature)
        {
            return _repository.Add(feature);
        }

        public bool Delete(int id)
        {
            _repository.Delete(id);
            return true;
        }

        public IQueryable<Feature> GetAll()
        {
            return _repository.GetAll();
        }

        public IQueryable<Feature> GetAll(Expression<Func<Feature, bool>> predicate)
        {
            return _repository.GetAll().Where(predicate);
        }

        public Feature GetById(int id)
        {
           return _repository.GetById(id);
        }

        public Feature GetFirstOrDefault(Expression<Func<Feature, bool>> predicate)
        {
           return _repository.GetFirstOrDefault(predicate);
        }

        public Feature Update(Feature feature)
        {
          return _repository.Update(feature);
        }
    }
}
