using Microsoft.EntityFrameworkCore;

namespace CateringPlanner.Models
{
	[PrimaryKey(nameof(PartyId), nameof(MenuItemId))]
	public class PartyMenuItem
	{

		public int PartyId { get; set; }
		public Party Party { get; set; }

		public int MenuItemId { get; set; }
		public MenuItem MenuItem { get; set; }
	}
}
