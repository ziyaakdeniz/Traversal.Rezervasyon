using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Web.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller


    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
