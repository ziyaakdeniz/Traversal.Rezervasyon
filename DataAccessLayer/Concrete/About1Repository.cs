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
    public class About1Repository : Repository<About1>, IAbout1Repository
    {
        public About1Repository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
