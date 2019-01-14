﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loggy.Api.Schema;

namespace Loggy.Api.DataAccess
{
	public interface IUserRepository
	{
		Task<User> GetByIdAsync(string userId);
	}
	
	public class UserRepository: IUserRepository
	{
		public Task<User> GetByIdAsync(string userId)
		{
			return Task.FromResult(new User());
		}
	}
}
