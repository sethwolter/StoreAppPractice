using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleUi
{
    class Product : Store
    {
        public override string ToString()
        {
            return "a product";
        }
        public Product(string name, string sku, decimal price)
        {
            Name = name;
            Sku = sku;
            Price = price;
        }
        public string Name { get; set; }
        public string Sku { get; set; }
        public decimal Price { get; set; }

        private IList<Product> products { get; set; }

        
        public Store();
        {
            products = new List<Product>
            {
                new Product("Ghurka Knife", "Ghu123", 19.95m),
                new Product("Bazooka", "Baz123", 199.95m),
                new Product("Pistol Ammo", "Pis123", 12.95m)
            };
            products.Add(new Product());

        return string.Format("{0}: {1}: {3}:")

        }


    }
}
