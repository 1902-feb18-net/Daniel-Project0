using System;
using System.Collections.Generic;
using System.Text;

namespace RedRobin.Library.Models
{
    public class IngPro
    {
        public int ingProID { get; set; }
        public int ingredientId { get; set; }
        public int productId { get; set; }
        public decimal ingProQty { get; set; }
    }
}
