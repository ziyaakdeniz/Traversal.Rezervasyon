using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Web.ViewComponents.Default
{

    public class _Statistics : ViewComponent
    {
        private readonly ApplicationDbContext _db;

        public _Statistics(ApplicationDbContext db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = _db.Destinations.Count();
            ViewBag.v2= _db.Guides.Count();
            return View();
        }
    }
}
