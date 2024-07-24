using BusinessLayer.Abstact;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Web.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {
        private readonly ITestimonialService _estimonialService;

        public _Testimonial(ITestimonialService estimonialService)
        {
            _estimonialService = estimonialService;
        }

        public IViewComponentResult Invoke()
        {
            var result= _estimonialService.GetAll().ToList();

            return View(result);
        }
    }
}
