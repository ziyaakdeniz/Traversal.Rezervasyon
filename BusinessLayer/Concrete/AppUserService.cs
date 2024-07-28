using BusinessLayer.Abstact;
using DataAccessLayer.Absract;
using DataAccessLayer.Shared.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class AppUserService : IAppUserService
	{
		//private readonly IRepository<AppUser> _repository;
		

		//public AppUserService(IRepository<AppUser> repository)
		//{
		//	_repository = repository;
		//}

		//public async Task<IdentityResult> CreateAsync(AppUser user, string password)
		//{
		//	return await _repository.CreateAsync(user, password);
		//}


		
	}
}

