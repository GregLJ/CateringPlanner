using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace CateringPlanner.Models
{
	public class Customer
	{
		public int Id { get; set; }

		[Required]
		public string? FirstName { get; set; }

		[Required]
		public string? LastName { get; set; }

		public string StreetAddress { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public int ZipCode { get; set; }

		[Required]
		public string PhoneNumber { get; set; }

		[EmailAddress]
		[Required]
		public string? Email { get; set; }

		//[InverseProperty("Customer")]
		public ICollection<Party> Parties { get; set; } = new List<Party>();
	}
}
