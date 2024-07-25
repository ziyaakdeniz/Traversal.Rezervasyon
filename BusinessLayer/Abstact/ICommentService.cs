using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstact
{
    public interface ICommentService
    {
        IQueryable<Comment> GetAll();

        Comment Add(Comment comment);

        Comment Update(Comment comment);

        bool Delete(int id);

        IQueryable<Comment> GetAll(Expression<Func<Comment, bool>> predicate);

        Comment GetById(int id);

        Comment GetFirstOrDefault(Expression<Func<Comment, bool>> predicate);

    }
}
