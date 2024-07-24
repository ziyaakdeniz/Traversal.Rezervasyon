using BusinessLayer.Abstact;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Web.Controllers
{
    public class DestinationalController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationalController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View(_destinationService.GetAll().ToList());
        }

        [HttpGet]
        public ActionResult DestinationalDetails(int id)
        {
            return View(_destinationService.GetById(id));
        }
        [HttpPost]
        public IActionResult DestinationalDetails(Destination destination)
        {
            return View();
        }
    }
}
