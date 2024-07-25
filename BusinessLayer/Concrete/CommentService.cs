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
    public class CommentService : ICommentService
    {
        private readonly IRepository<Comment> _commentRepository;

        public CommentService(IRepository<Comment> commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public Comment Add(Comment comment)
        {
            return _commentRepository.Add(comment);
        }

        public bool Delete(int id)
        {
           _commentRepository.Delete(id);
            return true;
        }

        public IQueryable<Comment> GetAll()
        {
            return _commentRepository.GetAll();
        }

        public IQueryable<Comment> GetAll(Expression<Func<Comment, bool>> predicate)
        {
            return _commentRepository.GetAll().Where(predicate);
        }

        public Comment GetById(int id)
        {
           return _commentRepository.GetById(id);
        }

        public Comment GetFirstOrDefault(Expression<Func<Comment, bool>> predicate)
        {
           return _commentRepository.GetFirstOrDefault(predicate);
        }

        public Comment Update(Comment comment)
        {
          return _commentRepository.Update(comment);
        }
    }
}
