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
            modelBuilder
                .Entity<Customer>()
                .HasData(new Customer { FirstName = "Bob", LastName = "Blart", StreetAddress = "123 Nowhere Lane", City = "Nowhere", State = "Alaska", ZipCode = 01234, PhoneNumber = "545-555-5454", Email = "bob@bobble.com" },
							new Customer { FirstName = "Becky", LastName = "Blazer", StreetAddress = "123 Somewhere Lane", City = "Somewhere", State = "Arizona", ZipCode = 43210, PhoneNumber = "454-555-4545", Email = "becky@bobble.com" });
			modelBuilder
				.Entity<MenuItem>()
				.HasData(new MenuItem { });
			modelBuilder
				.Entity<Ingredient>()
				.HasData(new Ingredient { Name = "Mushrooms"});


        }
    }
}