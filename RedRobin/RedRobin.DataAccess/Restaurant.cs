using System;
using System.Collections.Generic;

namespace RedRobin.DataAccess
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            Orders = new HashSet<Orders>();
            ResIng = new HashSet<ResIng>();
            ResPro = new HashSet<ResPro>();
        }

        public int RestaurantId { get; set; }
        public string RestLocation { get; set; }
        public string RestPhone { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<ResIng> ResIng { get; set; }
        public virtual ICollection<ResPro> ResPro { get; set; }
    }
}
