using BusinessLayer.Abstact;
using EntityLayer.Concrete;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Traversal.Web.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]


    public class ReservationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly IReservationService _reservationService;
        private readonly Microsoft.AspNetCore.Identity.UserManager<AppUser> _userManager;

        public ReservationController(IDestinationService destinationService, IReservationService reservationService, Microsoft.AspNetCore.Identity.UserManager<AppUser> userManager)
        {
            _destinationService = destinationService;
            _reservationService = reservationService;
            _userManager = userManager;

        }

        public IActionResult MyCurrentReservation()
        {

            return View();
        }

        public async Task<IActionResult> MyApprovalReservation()
        { 
            var result=await _userManager.FindByNameAsync(User.Identity.Name);
            
           ViewBag.Id=result.Id;
            var reservations =  _reservationService.GetAll().Where(x => x.status.StartsWith("Onay") && x.AppUserId==result.Id).ToList();

            return View(reservations);
        }


        public IActionResult MyOldReservation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            //List<SelectListItem> values = (from x in _destinationService.GetAll()
            //                               select new SelectListItem
            //                               {
            //                                   Text = x.City,
            //                                   Value = x.Id.ToString()
            //                               }).ToList();
            List<SelectListItem> values = _destinationService.GetAll().Select(x => new SelectListItem
            {
                Text = x.City,
                Value = x.Id.ToString()
            }).ToList();

            ViewBag.result = values;
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            reservation.status = "Onay Bekliyor";
            reservation.AppUserId = 3;
            _reservationService.Add(reservation);

            return RedirectToAction("MyCurrentReservation");
        }

        
    }
}
