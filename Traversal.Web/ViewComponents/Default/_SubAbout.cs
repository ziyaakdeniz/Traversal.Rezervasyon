using BusinessLayer.Abstact;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Web.ViewComponents.Default
{
    public class _SubAbout:ViewComponent
    {

        private readonly ISubAboutService _subAboutService;

        public _SubAbout(ISubAboutService subAboutService)
        {
            _subAboutService = subAboutService;
        }

        public IViewComponentResult Invoke()
        {
            var result=_subAboutService.GetAll().ToList();

            return View(result);
        }
    }
}
