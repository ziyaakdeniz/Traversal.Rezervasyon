using BusinessLayer.Concrete;
using DataAccessLayer;
using DataAccessLayer.Shared.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Web.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        private readonly IRepository<Feature> _repository;

        public _Feature(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke()
        {
            var result=_repository.GetAll().ToList();
            return View(result);
        }
    }
}
