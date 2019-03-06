using System;
using System.Collections.Generic;

namespace RedRobin.DataAccess
{
    public partial class Orders
    {
        public Orders()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        public int OrderId { get; set; }
        public DateTime OrdDate { get; set; }
        public decimal OrdCost { get; set; }
        public int CustomerId { get; set; }
        public int RestaurantId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
