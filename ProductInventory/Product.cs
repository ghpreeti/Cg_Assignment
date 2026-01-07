using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInventory
{
    internal class Product : IProduct
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
    }
}
