using System;
using System.Collections.Generic;

namespace RedRobin.DataAccess
{
    public partial class Product
    {
        public Product()
        {
            IngPro = new HashSet<IngPro>();
            OrderProduct = new HashSet<OrderProduct>();
            ResPro = new HashSet<ResPro>();
        }

        public int ProductId { get; set; }
        public string ProType { get; set; }
        public string ProName { get; set; }
        public decimal ProCost { get; set; }

        public virtual ICollection<IngPro> IngPro { get; set; }
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
        public virtual ICollection<ResPro> ResPro { get; set; }
    }
}
