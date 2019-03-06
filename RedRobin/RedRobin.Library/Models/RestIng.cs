using System;
using System.Collections.Generic;
using System.Text;

namespace RedRobin.Library.Models
{
    public class RestIng
    {
        public int resIngID { get; set; }
        public int ingredientId { get; set; }
        public int restaurantId { get; set; }
        public decimal resIngQty { get; set; }
    }
}
