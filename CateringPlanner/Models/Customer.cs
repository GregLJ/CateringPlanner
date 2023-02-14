using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace CateringPlanner.Models
{
	public class Customer
	{
		public int Id { get; set; }

		[Required]
		[DisplayName("First Name")]
		public string? FirstName { get; set; }

		[Required]
        [DisplayName("Last Name")]
        public string? LastName { get; set; }
        [DisplayName("Street Address")]
        public string? StreetAddress { get; set; }
		public string? City { get; set; }
		public string? State { get; set; }
        [DisplayName("Zip Code")]
        public string? ZipCode { get; set; }

		[Required]
        [DisplayName("Phone Number")]
        public string? PhoneNumber { get; set; }

		[EmailAddress]
		[Required]
		public string? Email { get; set; }

		//[InverseProperty("Customer")]
		public ICollection<Party> Parties { get; set; } = new List<Party>();
	}
}
