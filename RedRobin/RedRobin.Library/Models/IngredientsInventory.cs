using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RedRobin.Library.Models
{
    public class IngredientsInventory
    {
        public int Id { get; set; }

        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Name of the Ingredient must be provided.");
                }
                _name = value;
            }
        }

        public decimal Cost { get; set; }

    }
}
