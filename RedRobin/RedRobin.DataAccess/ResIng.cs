using System;
using System.Collections.Generic;

namespace RedRobin.DataAccess
{
    public partial class ResIng
    {

        public int ResIngId { get; set; }
        public int RestaurantId { get; set; }
        public int IngredientId { get; set; }
        public decimal Qty { get; set; }

        public virtual Ingredients Ingredient { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
