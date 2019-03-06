using System;
using System.Collections.Generic;
using System.Text;

namespace RedRobin.Library.Models
{
    public class Products
    {
        public int Id { get; set; }

        public string Type { get; set; }

        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Name of the Burger must be provided.");
                }
                _name = value;
            }
        }

        public List<IngredientsInventory> Ingredients { get; set; } = new List<IngredientsInventory>();


        public decimal Cost { get; set; }


        //private double? _cost;

        //public double? Cost
        //{
        //    get => _cost;
        //    set
        //    {
        //        double? sumCost = 0;

        //        foreach (var item in Ingredients)
        //        {
        //            sumCost += item.Cost;
        //        }
        //        _cost = sumCost;
        //    }
        //}
    }
}
