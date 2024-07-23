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
    public class About2Repository : Repository<About2>, IAbout2Repository
    {
        public About2Repository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
