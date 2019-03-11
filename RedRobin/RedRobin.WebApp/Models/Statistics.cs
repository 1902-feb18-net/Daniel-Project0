using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedRobin.WebApp.Models
{
    public class Statistics
    {

        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Product Name")]
        public string productName { get; set; }

        [Display(Name = "Type")]
        public string Type { get; set; }

        [Display(Name = "Total Cost")]
        public decimal TotalCost { get; set; }

        [Display(Name = "Revenue from Prod.")]
        public decimal RevenueCost { get; set; }

        [Display(Name = "Qty of sales")]
        public int productCount { get; set; }
    }
}
