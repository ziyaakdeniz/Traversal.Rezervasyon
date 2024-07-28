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
	public class AppRoleRepository : Repository<AppRole>, IAppRoleRepository
	{
		public AppRoleRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
