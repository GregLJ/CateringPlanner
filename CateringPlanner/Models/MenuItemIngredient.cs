using Microsoft.EntityFrameworkCore;

namespace CateringPlanner.Models
{
	[PrimaryKey(nameof(MenuItemId), nameof(IngredientId))]
	public class MenuItemIngredient
	{
		public int MenuItemId { get; set; }
		public MenuItem MenuItem { get; set; }
		public int IngredientId { get; set; }
		public Ingredient Ingredient { get; set; }

		public int Quantity { get; set; }
	}
}
