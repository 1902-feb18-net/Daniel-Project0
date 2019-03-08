using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedRobin.WebApp.Models
{
    public class Ingredient
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        public string name { get; set; }

        public decimal Qty { get; set; }

        public decimal Cost { get; set; }

        public string Restaurant { get; set; }
    }
}
