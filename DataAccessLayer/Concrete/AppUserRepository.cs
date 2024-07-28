using DataAccessLayer.Absract;
using DataAccessLayer.Shared.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
	public class AppUserRepository : Repository<AppUser>, IAppUserRepository
	{
		//private readonly UserManager<AppUser> _userManager;
		//private readonly ApplicationDbContext _context;

		//public AppUserRepository(UserManager<AppUser> userManager, ApplicationDbContext context) : base(context)
		//{
		//	_userManager = userManager;
		//	_context = context;
		//}

		//AppUser IAppUserRepository.CreateAsync(AppUser user, string password)
		//{

		//}
		public AppUserRepository(ApplicationDbContext context) : base(context)
		{

		}
	}
}
