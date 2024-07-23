using BusinessLayer.Concrete;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Web.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        private readonly FeatureService _featureService;

        public _Feature(FeatureService featureService)
        {
            _featureService = featureService;
        }

        public IViewComponentResult Invoke()
        {
            var result=_featureService.GetAll().ToList();
            return View(result);
        }
    }
}
