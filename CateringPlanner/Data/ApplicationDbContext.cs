using CateringPlanner.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CateringPlanner.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
	
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<Customer> Customers { get; set; }
		public DbSet<MenuItem> MenuItems { get; set; }
		public DbSet<Ingredient> Ingredients { get; set; }
		public DbSet<MenuItemIngredient> MenuItemIngredients { get; set; }
		public DbSet<Party> Party { get; set; }
		public DbSet<PartyMenuItem> PartyMenuItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DataSeeder.SeedData(modelBuilder);
			base.OnModelCreating(modelBuilder);
        }
    }
}