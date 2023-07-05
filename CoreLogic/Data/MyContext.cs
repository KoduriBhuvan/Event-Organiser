using CoreLogic.Models;
using Microsoft.EntityFrameworkCore;

namespace EFGetStarted
{
	public class MyContext : DbContext
	{
		public DbSet<User> User { get; set; }
		public DbSet<Events> Events { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			var server = "(localdb)";
			var instance = "mssqllocaldb";
			var database = "UserDB";
			var authentication = "Integrated Security = true";

			var conString = $"Data Source={server}\\{instance}; Initial Catalog={database};{authentication}";

			options.UseSqlServer(conString);
		}
	}
}