using AutoAm.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoAm.Core.Interfaces
{
	public interface IAutoRepository
	{
		void Add(Auto auto);
		void Delete(Auto auto);
		Auto GetById(int Id);
		List<Auto> GetAll();
		void SaveChanges();
	}
}
