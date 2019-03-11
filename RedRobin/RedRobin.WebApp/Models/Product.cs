using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedRobin.WebApp.Models
{
    public class Product
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Product Name")]
        [Required]
        public string productName { get; set; }

        [Display(Name = "Type")]
        [Required]
        public string Type { get; set; }

        [Display(Name = "Product Cost: $")]
        public decimal TotalCost { get; set; }

        public string Restaurant { get; set; }

        [Display(Name = "ID")]
        public int OngredientID { get; set; }

        public string ingredientName { get; set; }

        [Required]
        //[Range(1, 10, ErrorMessage = "Must add between 1 and 10  products")]
        public int QtyOrder { get; set; }

        public decimal Cost { get; set; }


    }
}
