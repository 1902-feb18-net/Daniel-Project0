using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedRobin.WebApp.Models
{
    public class Restaurant
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        [Display(Name = "Restaurant Phone: (xxx)xxx-xxxx")]
        [RegularExpression(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}", ErrorMessage = "Must Enter a valid phone number")]
        public string Phone { get; set; }
    }
}
