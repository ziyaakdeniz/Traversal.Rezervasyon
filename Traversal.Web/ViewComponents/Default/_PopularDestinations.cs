using BusinessLayer.Abstact;
using BusinessLayer.Concrete;
using DataAccessLayer.Absract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace Traversal.Web.ViewComponents.Default
{
    public class _PopularDestinations:ViewComponent
    {
       private readonly IDestinationService _destinationService;

        public _PopularDestinations(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            List<Destination> result= _destinationService.GetAll().ToList();
            return View(result);
        }
    }
}
