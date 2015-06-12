using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleUi
{
    public class Product 
    {

        public Product(string name, string sku, decimal price)
        {
            Name = name;
            Sku = sku;
            Price = price;
        }
        public string Name { get; set; }
        public string Sku { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return string.Format("({0}) {1}: {2}", Sku, Name, Price);
        }
    }
}
