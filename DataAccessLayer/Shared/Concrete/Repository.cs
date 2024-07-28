using DataAccessLayer.Shared.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Shared.Concrete
{
	public class Repository<T> : IRepository<T> where T : class
	{
		private readonly ApplicationDbContext _context;
		private readonly DbSet<T> _dbSet;

		public Repository(ApplicationDbContext context)
		{
			_context = context;
			_dbSet = _context.Set<T>();
		}

		public T Add(T entity)
		{
			_dbSet.Add(entity);
			Save();
			return entity;
		}

		public void Delete(int entityId)
		{
			T entity = _dbSet.Find(entityId);
			_dbSet.Remove(entity);
			Save();
		}

		public IQueryable<T> GetAll()
		{
			return _dbSet;
		}

		public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
		{
			return GetAll().Where(predicate);
		}

		public T GetById(int entityId)
		{
			T entity = _dbSet.Find(entityId);
			return entity;
		}

		public T GetFirstOrDefault(Expression<Func<T, bool>> predicate)
		{
			return _dbSet.FirstOrDefault(predicate);
		}

		public void Save()
		{
			_context.SaveChanges();
		}

		public T Update(T entity)
		{
			_dbSet.Update(entity);
			Save();
			return entity;
		}
	}
}
