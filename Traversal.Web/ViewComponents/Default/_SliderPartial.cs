using Microsoft.AspNetCore.Mvc;

namespace Traversal.Web.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
