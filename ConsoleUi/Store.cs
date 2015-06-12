using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreProject.Core

{
    public class Store
    {
        private IList<Product> products;

        public Store();
        {
            products = new List<Product>
            {
                new Product("Ghurka Knife", "Ghu123", 19.95m),
                new Product("Bazooka", "Baz123", 199.95m),
                new Product("Pistol Ammo", "Pis123", 12.95m)
            };
        }

        public IEnumerable<Product> AllProducts()
        {
            return products;
        }
    }     
} 
    

