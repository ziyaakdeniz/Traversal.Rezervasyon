using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstact
{
    public interface IFeatureService
    {
        Feature Add(Feature feature);
        Feature Update(Feature feature);
        bool Delete(int id);
        IQueryable<Feature> GetAll();
        IQueryable<Feature>GetAll(Expression<Func<Feature, bool>> predicate);
        Feature GetById(int id);
        Feature GetFirstOrDefault(Expression<Func<Feature, bool>> predicate);


    }
}
