using AutoAm.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAm.Core.Interfaces
{
	public interface IUserRepository
	{
		void Add(User user);
		void Delete(User user);
		User GetById(int Id);
		List<User> GetAll();
		void SaveChanges();
	}
}