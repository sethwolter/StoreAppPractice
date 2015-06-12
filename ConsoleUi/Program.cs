using StoreProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUi
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new Store();

            while (true)
            {
                switch(ShowMainMenu())
                {
                        
                    case "q":
                        return;
                    case "l":
                        ListProducts(store);
                        break;
                }
            }
        }

        private static string ShowMainMenu()
        {
            Console.WriteLine("Welcome to Cletus's Products for Special Store");
            Console.WriteLine("=================================================================");
            Console.WriteLine();
            Console.WriteLine("To see a list of our current inventory press: 'l' ");
            Console.WriteLine("****that's an 'l' as in 'lizard' or 'lollipop' you ninny!!!******");
            Console.WriteLine();
            Console.WriteLine("If you are done press 'q' to quit.");
            Console.WriteLine("****that's a 'q' as in quitter...****");
            Console.WriteLine();
            return Console.ReadLine().Trim().ToLower();
        }

        private static void ListProducts(Store store)
        {
            foreach(var product in store.AllProducts())
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}
