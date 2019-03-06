using System;
using System.Collections.Generic;

namespace RedRobin.DataAccess
{
    public partial class Ingredients
    {
        public Ingredients()
        {
            IngPro = new HashSet<IngPro>();
            ResIng = new HashSet<ResIng>();
        }

        public int IngredientId { get; set; }
        public string IngName { get; set; }
        public decimal IngCost { get; set; }

        public virtual ICollection<IngPro> IngPro { get; set; }
        public virtual ICollection<ResIng> ResIng { get; set; }
    }
}
