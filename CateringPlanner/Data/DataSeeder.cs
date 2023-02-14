using CateringPlanner.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CateringPlanner.Data
{
    public static class DataSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Customer>()
                .HasData(new Customer { Id = 10, FirstName = "Bob", LastName = "Blart", StreetAddress = "123 Nowhere Lane", City = "Nowhere", State = "Alaska", ZipCode = "01234", PhoneNumber = "545-555-5454", Email = "bob@bobble.com" },
                            new Customer { Id = 11, FirstName = "Becky", LastName = "Blazer", StreetAddress = "123 Somewhere Lane", City = "Somewhere", State = "Arizona", ZipCode = "43210", PhoneNumber = "454-555-4545", Email = "becky@bobble.com" });
            modelBuilder
                .Entity<MenuItem>()
                .HasData(new MenuItem { Id = 101, Name = "Chicken Marsala" });
            modelBuilder
                .Entity<Ingredient>()
                .HasData(new Ingredient { Id = 1, Name = "Mushrooms" },
                            new Ingredient { Id = 2, Name = "Onions" },
                            new Ingredient { Id = 3, Name = "Marsala Wine" },
                            new Ingredient { Id = 4, Name = "Chicken Stock" },
                            new Ingredient { Id = 5, Name = "Garlic" },
                            new Ingredient { Id = 6, Name = "Parsley(fresh)" },
                            new Ingredient { Id = 7, Name = "Egg Noodles" },
                            new Ingredient { Id = 8, Name = "Broccoli" },
                            new Ingredient { Id = 9, Name = "Flour" },
                            new Ingredient { Id = 10, Name = "Oil Blend" },
                            new Ingredient { Id = 11, Name = "Chicken Tenders" });
            modelBuilder
                .Entity<MenuItemIngredient>()
                .HasData(new MenuItemIngredient { MenuItemId = 101, IngredientId = 1 },
                            new MenuItemIngredient { MenuItemId = 101, IngredientId = 2, Quantity = 1 },
                            new MenuItemIngredient { MenuItemId = 101, IngredientId = 3, Quantity = 1 },
                            new MenuItemIngredient { MenuItemId = 101, IngredientId = 4, Quantity = 1 },
                            new MenuItemIngredient { MenuItemId = 101, IngredientId = 5, Quantity = 1 },
                            new MenuItemIngredient { MenuItemId = 101, IngredientId = 6, Quantity = 1 },
                            new MenuItemIngredient { MenuItemId = 101, IngredientId = 7, Quantity = 1 },
                            new MenuItemIngredient { MenuItemId = 101, IngredientId = 8, Quantity = 1 },
                            new MenuItemIngredient { MenuItemId = 101, IngredientId = 9, Quantity = 1 },
                            new MenuItemIngredient { MenuItemId = 101, IngredientId = 10, Quantity = 1 },
                            new MenuItemIngredient { MenuItemId = 101, IngredientId = 11, Quantity = 1 });
            modelBuilder
                .Entity<Party>()
                .HasData(new Party { Id = 1, CustomerId = 10, NumberOfPeople = 10, DateTime = new DateTime(2023, 7, 4) });

            modelBuilder
                .Entity<PartyMenuItem>()
                .HasData(new PartyMenuItem { PartyId = 1, MenuItemId = 101 });
        }
    }
}
