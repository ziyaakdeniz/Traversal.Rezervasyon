using DataAccessLayer.Shared.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Absract
{
	public interface IAppUserRepository : IRepository<AppUser>
	{
		//AppUser CreateAsync(AppUser user,string password);
	}
}

	
