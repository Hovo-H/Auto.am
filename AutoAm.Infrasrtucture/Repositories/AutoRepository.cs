using AutoAm.Core.Data;
using AutoAm.Core.Interfaces;

namespace AutoAm.Infrastructure.Repositories
{
	public class AutoRepository : IAutoRepository
	{
		private readonly AutoAmDbContext _context;
		public AutoRepository(AutoAmDbContext context)
		{
			_context = context;
		}

		public void Add(Auto auto)
		{
			_context.Autos.Add(auto);
			_context.SaveChanges();
		}

		public void Delete(Auto auto)
		{
			_context.Autos.Remove(auto);
		}

		public List<Auto> GetAll()
		{
			return _context.Autos.ToList();
		}

		public Auto GetById(int Id)
		{
			return _context.Autos.Find(Id);
		}

		public void SaveChanges()
		{
			_context.SaveChanges();
		}
	}
}
