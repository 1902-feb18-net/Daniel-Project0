using System;
using System.Collections.Generic;

namespace RedRobin.DataAccess
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }

        public int CustomerId { get; set; }
        public string CustName { get; set; }
        public string CustPhone { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
