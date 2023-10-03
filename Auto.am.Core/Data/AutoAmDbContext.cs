using AutoAm.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAm.Core.Data
{
	public class AutoAmDbContext : DbContext
	{
		public AutoAmDbContext(DbContextOptions opt) : base(opt) 
		{

		}
		public DbSet<Auto> Autos { get; set; }
		public DbSet<AutoVariant> Variants { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Vendor> Vendors { get; set; }
	}
}
