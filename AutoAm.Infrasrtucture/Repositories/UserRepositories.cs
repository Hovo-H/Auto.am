using AutoAm;
using AutoAm.Core.Data;
using AutoAm.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
	public class UserRepositories:IUserRepository
	{
		private readonly AutoAmDbContext _context;
		public UserRepositories(AutoAmDbContext context)
		{
			_context = context;
		}

		public void Add(User user)
		{
			_context.Users.Add(user);
			_context.SaveChanges();
		}

		public void Delete(User user)
		{
			_context.Users.Remove(user);
		}

		public List<User> GetAll()
		{
			return _context.Users.ToList();
		}

		public User GetById(int Id)
		{
			return _context.Users.Find(Id);
		}

		public void SaveChanges()
		{
			_context.SaveChanges();
		}
	}
}
