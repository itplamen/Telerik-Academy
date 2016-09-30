// 02.Write a program to read a large collection of products (name + price) and efficiently find the first 20 products in the price range [a…b]. 
// Test for 500 000 products and 10 000 price searches.
// Hint: you may use OrderedBag<T> and sub-ranges.

namespace _02.CollectionOfProducts
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        private static Random generator = new Random();
        private static Stopwatch watch = new Stopwatch();

        public static void AddProducts(Store store, int numberOfProducts)
        {
            for (int i = 1; i <= numberOfProducts; i++)
            {
                double price = generator.Next(2000);
                store.Add(new Product(string.Empty, price));
            }
        }

        public static void FindProducts(Store store, int numberOfSearches)
        {
            for (int i = 1; i <= numberOfSearches; i++)
            {
                double minPrice = generator.Next(100);
                double maxPrice = generator.Next(500, 2000);
                store.FindInRange(minPrice, maxPrice);
            }
        }

        public static void Main(string[] args)
        {
            Store store = new Store();
            watch.Start();
            AddProducts(store, 500000);
            watch.Stop();
            Console.WriteLine("Time for adding 500 000 products: " + watch.Elapsed);

            watch.Start();
            FindProducts(store, 10000);
            watch.Stop();
            Console.WriteLine("Time for search the products: " + watch.Elapsed);
        }
    }
}
