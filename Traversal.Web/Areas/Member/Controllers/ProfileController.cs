
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Traversal.Web.Areas.Member.Models;
using Traversal.Web.Models;

namespace Traversal.Web.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]

    public class ProfileController : Controller
    {
      private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async  Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name); 
            UserEditVM userEditVM=new UserEditVM();

            userEditVM.name = values.Name;
            userEditVM.surname = values.Surname;
            userEditVM.phonenumber = values.PhoneNumber;
            userEditVM.mail = values.Email;
             
            return View(userEditVM);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditVM userEditWM)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);


            if(userEditWM.ImageFile!=null)
            {
                var resource=Directory.GetCurrentDirectory();
                var extension=Path.GetExtension(userEditWM.ImageFile.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation=resource+"/wwwroot/UserImage/"+imagename;
                var stream=new FileStream(savelocation, FileMode.Create);
                await userEditWM.ImageFile.CopyToAsync(stream);
                user.ImageUrl=imagename;
            }
            user.Surname = userEditWM.surname;
            user.Name=userEditWM.name;
            user.PasswordHash=_userManager.PasswordHasher.HashPassword(user,userEditWM.password);
            var result=await _userManager.UpdateAsync(user);
            if(result.Succeeded)
            {
                return RedirectToAction("SingIn", "Login");
            }
            return View();
        }
    }
}
