using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class Party
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int NumberOfPeople { get; set; }
        public DateTime DateTime { get; set; }
        public ICollection<PartyMenuItem> PartyMenuItems { get; set; }
    }
}
