using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedRobin.WebApp.Models
{
    public class Ingredient
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Ingredient Name")]
        public string name { get; set; }

        //[Required]
        [Display(Name = "Qty to Add")]
        //[Range(1,10,ErrorMessage ="Must add between 1 and 10 pounds of a product")]
        public decimal QtyToAdd { get; set; }

        [Required]
        //[Range(1, 300, ErrorMessage = "Must add between 1 and 300 pounds of a products")]
        [Display(Name = "Qty in Stock")]
        public decimal QtyToStock { get; set; }

        [Required]
        //[Range(1, 10, ErrorMessage = "The price must be between $1 and $9.99")]
        [Display(Name = "Ingredient Cost: $")]
        public decimal Cost { get; set; }

        public string Restaurant { get; set; }

        public bool hasIngredient { get; set; }
    }
}
