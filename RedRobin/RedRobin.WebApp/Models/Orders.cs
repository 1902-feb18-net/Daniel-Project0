using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedRobin.WebApp.Models
{
    public class Orders
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        // [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        [Display(Name = "Order Date")]
        public DateTime orderDate { get; set; }

        [Display(Name = "Total Cost: $")]
        public decimal orderTotal { get; set; }

        [Display(Name = "Customer Name")]
        [Required]
        public string custName { get; set; }

        [Required]
        [Display(Name = "Customer Phone: (xxx)xxx-xxxx")]
        [RegularExpression(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}", ErrorMessage = "Must Enter a valid phone number")]
        public string custPhone { get; set; }

        public IEnumerable<Product> products { get; set; }
    }
}
