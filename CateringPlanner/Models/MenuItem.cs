using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<MenuItemIngredient> MenuItemIngredients { get; set; }
        public int PartyMenuItemId { get; set; }
        public PartyMenuItem PartyMenuItem { get; set; }

    }
}
