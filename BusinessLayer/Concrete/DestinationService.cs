using BusinessLayer.Abstact;
using DataAccessLayer.Shared.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationService : IDestinationService
    {
        private readonly IRepository<Destination> _destinationRepository;

        public DestinationService(IRepository<Destination> destinationRepository)
        {
            _destinationRepository = destinationRepository;
        }

        public Destination Add(Destination destination)
        {
          return _destinationRepository.Add(destination);
        }

        public bool Delete(int id)
        {
            _destinationRepository.Delete(id);
            return true;
        }

        public IQueryable<Destination> GetAll()
        {
           return _destinationRepository.GetAll();
        }

        public IQueryable<Destination> GetAll(Expression<Func<Destination, bool>> predicate)
        {
           return _destinationRepository.GetAll().Where(predicate);
        }

        public Destination GetById(int id)
        {
            return _destinationRepository.GetById(id);
        }

        public Destination GetFirstOrDefault(Expression<Func<Destination, bool>> predicate)
        {
           return _destinationRepository.GetFirstOrDefault(predicate);
        }

        public Destination Update(Destination destination)
        {
           return _destinationRepository.Update(destination);
        }
    }
}
