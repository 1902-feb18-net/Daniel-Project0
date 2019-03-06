using System;
using System.Collections.Generic;

namespace RedRobin.DataAccess
{
    public partial class ResPro
    {
        public int ResProId { get; set; }
        public int ProductId { get; set; }
        public int RestaurantId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
