using System.ComponentModel.DataAnnotations;
using System.IO;

namespace DataModels
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string?FirstName { get; set; }

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
        public ICollection<Party> Parties { get; set; }
    }
}