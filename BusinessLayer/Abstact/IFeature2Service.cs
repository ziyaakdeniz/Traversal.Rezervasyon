using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstact
{
    public interface IFeature2Service
    {
        Feature2 Add(Feature2 feature2);
        Feature2 Update(Feature2 feature2);
        bool Delete(int id);
        IQueryable<Feature2> GetAll();
        IQueryable<Feature2> GetAll(Expression<Func<Feature2, bool>> predicate);
        Feature2 GetById(int id);
        Feature2 GetFirstOrDefault(Expression<Func<Feature2, bool>> predicate);

    }
}
