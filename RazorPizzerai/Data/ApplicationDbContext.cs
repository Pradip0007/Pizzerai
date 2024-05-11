using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using RazorPizzerai.Models;

namespace RazorPizzerai.Data
{
	public class ApplicationDbContext:DbContext
	{
		public DbSet<PizzaOrder> PizzaOrders { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base()
		{

		}
	}
}

