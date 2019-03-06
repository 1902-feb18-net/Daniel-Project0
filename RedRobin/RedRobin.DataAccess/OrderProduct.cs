﻿using System;
using System.Collections.Generic;

namespace RedRobin.DataAccess
{
    public partial class OrderProduct
    {
        public int OrdProId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
