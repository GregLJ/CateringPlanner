namespace CateringPlanner.Models
{
	public class Ingredient
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<MenuItemIngredient> MenuItemIngredients { get; set; } = new List<MenuItemIngredient>();

	}
}
