using System;
using System.Collections.Generic;
using System.Text;

namespace RedRobin.Library.Models
{
    public class Orders
    {
        public int Id { get; set; }

        public int cutomerID { get; set; }

        public int restaurantID { get; set; }

        public DateTime orderDate { get; set; }

        //public decimal _costBurgers;

        //public decimal CostBurgers
        //{
        //    get => _costBurgers;
        //    set
        //    {
        //        decimal sumCostBurgers = 0;

        //        foreach (var item in burgers)
        //        {
        //            sumCostBurgers += item.Cost;
        //        }
        //        _costBurgers = sumCostBurgers;
        //    }
        //}

        //public decimal _costDrinks;

        //public decimal CostDrinks
        //{
        //    get => _costDrinks;
        //    set
        //    {
        //        decimal sumCostDrinks = 0;

        //        foreach (var item in burgers)
        //        {
        //            sumCostDrinks += item.Cost;
        //        }
        //        _costDrinks = sumCostDrinks;
        //    }
        //}

        //public decimal _costSides;

        //public decimal CostSides
        //{
        //    get => _costSides;
        //    set
        //    {
        //        decimal sumCostDrinks = 0;

        //        foreach (var item in burgers)
        //        {
        //            sumCostDrinks += item.Cost;
        //        }
        //        _costSides = sumCostDrinks;
        //    }
        //}


        public decimal CostTotal { get; set; }
        public List<OrdPro> Products { get; set; } = new List<OrdPro>();

        //public decimal CostTotal
        //{
        //    get => _costTotal;
        //    set
        //    {
        //        decimal sumCost = CostBurgers + CostDrinks + CostSides;

        //        _costTotal = sumCost;
        //    }
        //}


    }
}
