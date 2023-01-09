using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
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
