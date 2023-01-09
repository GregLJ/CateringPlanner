namespace CateringPlanner.Models
{
	public class Party
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public Customer Customer { get; set; }
		public int NumberOfPeople { get; set; }
		public DateTime DateTime { get; set; }
		public ICollection<PartyMenuItem> PartyMenuItems { get; set; } = new List<PartyMenuItem>();
	}
}
