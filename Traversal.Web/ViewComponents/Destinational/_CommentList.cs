using BusinessLayer.Abstact;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Web.ViewComponents.Destinational
{
    public class _CommentList : ViewComponent
    {
        private readonly ICommentService _commentService;

        public _CommentList(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
           var result =_commentService.GetAll().Where(x=>x.DestinationId == id).ToList();

            return View(result);
        }
    }
}
