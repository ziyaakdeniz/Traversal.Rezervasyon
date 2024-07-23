using Microsoft.AspNetCore.Mvc;

namespace Traversal.Web.ViewComponents.Default
{
    public class _PopularDestinations:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
