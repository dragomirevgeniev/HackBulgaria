using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VATTaxCalculator;

namespace ShopInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryVatTax[] countries = new CountryVatTax[]
            {
                new CountryVatTax(1, 0.31, true),
                new CountryVatTax(2, 0.21, false),
                new CountryVatTax(3, 0.15, false),
                new CountryVatTax(4, 0.19, false),
                new CountryVatTax(5, 0.32, false),
                new CountryVatTax(6, 0.43, false)
            };

            TaxCalculator calc = new TaxCalculator(countries.ToList());

            Product[] products = new Product[]
            {
                new Product("Juice"  , 1, 1, 2, 0.7, calc),
                new Product("Cola"   , 2, 1, 3, 2.5, calc),
                new Product("Vodka"  , 3, 1, 6, 3.4, calc),
                new Product("Water"  , 4, 1, 2, 0.5, calc),
                new Product("Wiskey" , 5, 1, 4, 4.3, calc),
                new Product("Wine"   , 6, 1, 3, 3.2, calc)                
            };

            ShopInventory shop = new ShopInventory(products.ToList());

            Dictionary<int, int> items1 = new Dictionary<int, int>();
            items1.Add(2, 2);
            items1.Add(3, 3);
            items1.Add(5, 1);
            Order order1 = new Order(items1);

            Dictionary<int, int> items2 = new Dictionary<int, int>();
            items2.Add(1, 1);
            items2.Add(4, 1);
            items2.Add(2, 1);
            Order order2 = new Order(items2);
            
            Dictionary<int, int> items3 = new Dictionary<int, int>();
            items3.Add(6, 4);
            items3.Add(5, 1);
            items3.Add(3, 2);
            Order order3 = new Order(items3);

            try
            {
                Console.WriteLine("Audit: {0}", shop.Audit());
                Console.WriteLine("Order 1 value: {0}", shop.RequestOrder(order1));
                Console.WriteLine("Audit: {0}", shop.Audit());
                Console.WriteLine("Order 2 value: {0}", shop.RequestOrder(order2));
                Console.WriteLine("Audit: {0}", shop.Audit());
                Console.WriteLine("Order 3 value: {0}", shop.RequestOrder(order3));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }

            Console.WriteLine("Audit: {0}", shop.Audit());
        }
    }
}
