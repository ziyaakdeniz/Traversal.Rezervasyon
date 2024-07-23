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
    public class Feature2Service : IFeature2Service
    {
        private readonly IRepository<Feature2> _feature2Repository;

        public Feature2Service(IRepository<Feature2> feature2Repository)
        {
            _feature2Repository = feature2Repository;
        }

        public Feature2 Add(Feature2 feature2)
        {
            return _feature2Repository.Add(feature2);
        }

        public bool Delete(int id)
        {
           _feature2Repository.Delete(id);
            return true;
        }

        public IQueryable<Feature2> GetAll()
        {
            return _feature2Repository.GetAll();
        }

        public IQueryable<Feature2> GetAll(Expression<Func<Feature2, bool>> predicate)
        {
           return _feature2Repository.GetAll().Where(predicate);
        }

        public Feature2 GetById(int id)
        {
            return _feature2Repository.GetById(id);
        }

        public Feature2 GetFirstOrDefault(Expression<Func<Feature2, bool>> predicate)
        {
            return _feature2Repository.GetFirstOrDefault(predicate);
        }

        public Feature2 Update(Feature2 feature2)
        {
           return _feature2Repository.Update(feature2);
        }
    }
}
