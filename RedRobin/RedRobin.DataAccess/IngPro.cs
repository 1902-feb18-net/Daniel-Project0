using System;
using System.Collections.Generic;

namespace RedRobin.DataAccess
{
    public partial class IngPro
    {
        public int IngProId { get; set; }
        public int IngredientId { get; set; }
        public int ProductId { get; set; }
        public decimal Qty { get; set; }

        public virtual Ingredients Ingredient { get; set; }
        public virtual Product Product { get; set; }
    }
}
