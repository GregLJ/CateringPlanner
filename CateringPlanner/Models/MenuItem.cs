namespace CateringPlanner.Models
{
	public class MenuItem
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<MenuItemIngredient> MenuItemIngredients { get; set; } = new List<MenuItemIngredient>();
		public ICollection<PartyMenuItem> PartyMenuItem { get; set; } = new List<PartyMenuItem>();
	}
}
