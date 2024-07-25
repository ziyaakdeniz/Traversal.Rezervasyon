using BusinessLayer.Abstact;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Web.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddComment(Comment comment)
        {
            comment.ComentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            comment.Status = true;
            _commentService.Add(comment);

            return PartialView();
        }

    }
}
