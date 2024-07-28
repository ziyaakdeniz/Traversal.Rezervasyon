using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Shared.Abstract
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        T Add(T entity);

        T Update(T entity);

        void Delete(int entityId);

        IQueryable<T>GetAll(Expression<Func<T, bool>> predicate);

        T GetById(int entityId);

        T GetFirstOrDefault(Expression<Func<T, bool>> predicate);

        void Save();

    }
}
