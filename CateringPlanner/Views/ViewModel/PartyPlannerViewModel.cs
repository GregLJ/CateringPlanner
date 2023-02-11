using CateringPlanner.Models;
using System.ComponentModel;

namespace CateringPlanner.Views.ViewModel
{
    public class PartyPlannerViewModel
    {
        [DisplayName("Menu Items")]
        public List<MenuItem> MenuItems { get; set; }
        public Customer Customer { get; set; }
        public MenuItem MenuItem { get; set; }
        public Party Party { get; set; }
    }
}
