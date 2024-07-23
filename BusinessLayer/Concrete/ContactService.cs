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
    public class ContactService : IContactService
    {
        private readonly IRepository<Contact> _repo;

        public ContactService(IRepository<Contact> repo)
        {
            _repo = repo;
        }

        public Contact Add(Contact contact)
        {
           return _repo.Add(contact);
        }

        public bool Delete(int id)
        {
           _repo.Delete(id);
            return true;
        }

        public IQueryable<Contact> GetAll()
        {
            return _repo.GetAll();
        }

        public IQueryable<Contact> GetAll(Expression<Func<Contact, bool>> predicate)
        {
           return _repo.GetAll().Where(predicate);
        }

        public Contact GetById(int id)
        {
           return _repo.GetById(id);
        }

        public Contact GetFirstOrDefault(Expression<Func<Contact, bool>> predicate)
        {
            return _repo.GetFirstOrDefault(predicate);
        }

        public Contact Update(Contact contact)
        {
            return _repo.Update(contact);
        }
    }
}
