using Microsoft.AspNetCore.Mvc;

namespace Traversal.Web.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
