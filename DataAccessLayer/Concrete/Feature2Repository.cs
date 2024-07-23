using DataAccessLayer.Absract;
using DataAccessLayer.Shared.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Feature2Repository : Repository<Feature2>, IFeature2Repository
    {
        public Feature2Repository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
