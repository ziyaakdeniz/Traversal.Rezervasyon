using Microsoft.AspNetCore.Mvc;

namespace Traversal.Web.Controllers
{
    public class LoginController : Controller
    {


        [HttpGet]
        public IActionResult SingUp()
        {
            return View();
        }
        [HttpPost]


        //public IActionResult SingUp()
        //{

        //    return View();
        //}



        [HttpGet]
        public IActionResult SingIn()
        {
            return View();
        }

        
    }
}
