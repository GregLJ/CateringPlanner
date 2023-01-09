using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    [PrimaryKey(nameof(MenuItemId), nameof(IngredientId))]
    public class MenuItemIngredient
    {
        public int MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public int Quantity { get; set; }
    }
}