using BusinessLayer.Abstact;
using DataAccessLayer;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Traversal.Web.Models;

namespace Traversal.Web.Controllers
{
	[AllowAnonymous]
	public class LoginController : Controller
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly SignInManager<AppUser> _signInManager;

       
        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
		public IActionResult SingUp()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> SingUp(UserRegisterWM appUser)
		{
			AppUser user = new AppUser()
			{
				Name = appUser.Name,
				Surname = appUser.Surname,
				Email = appUser.Mail,
				UserName = appUser.Username
			};
			if (appUser.Password == appUser.ConfirmPassword)
			{
				var result = await _userManager.CreateAsync(user, appUser.Password);

				if (result.Succeeded)
				{
					return RedirectToAction("SignIn");
				}
				else
				{
					foreach (var item in result.Errors)
					{
						ModelState.AddModelError("", item.Description);
					}
				}
			}
			return View(appUser);
		}

        [HttpGet]
        public IActionResult SingIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SingIn(UserSignInVM  userSignInVM)
        {
            //if (ModelState.IsValid)
            //{
                var result = await _signInManager.PasswordSignInAsync(userSignInVM.username, userSignInVM.password, false, true);
                if (result.Succeeded)
                {
					// return RedirectToAction("Index", "Profile", new { area = "Member" });
					return RedirectToAction("/Default/Index");
                }
                else
                {
                    return RedirectToAction("SingIn", "Login");
                }
            //}
            return View();
        }

    }
}
