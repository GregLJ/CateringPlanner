using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CateringPlanner.Models
{
	public class Party
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public Customer Customer { get; set; }
		[DisplayName("Number of people attending")]
		public int NumberOfPeople { get; set; }
		[DisplayName("Date of Party")]
		public DateTime DateTime { get; set; }
		public ICollection<PartyMenuItem> PartyMenuItems { get; set; } = new List<PartyMenuItem>();
	}
}
