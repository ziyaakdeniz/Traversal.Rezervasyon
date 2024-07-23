using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstact
{
    public interface IContactService
    {
        Contact Add(Contact contact);

        Contact Update(Contact contact);

        bool Delete(int id);

        IQueryable<Contact> GetAll();

        IQueryable<Contact>GetAll(Expression<Func<Contact, bool>> predicate);

        Contact GetById(int id);

        Contact GetFirstOrDefault(Expression<Func<Contact,bool>>predicate);

    }
}
