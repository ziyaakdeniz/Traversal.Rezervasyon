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
        private readonly IDestinationRepository _destinationRepository;

        public _PopularDestinations(IDestinationRepository destinationRepository)
        {
            _destinationRepository = destinationRepository;
        }

        public IViewComponentResult Invoke()
        {
            var result= _destinationRepository.GetAll().ToList();
            return View(result);
        }
    }
}
