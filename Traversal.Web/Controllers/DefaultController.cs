using Microsoft.AspNetCore.Mvc;

namespace Traversal.Web.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
