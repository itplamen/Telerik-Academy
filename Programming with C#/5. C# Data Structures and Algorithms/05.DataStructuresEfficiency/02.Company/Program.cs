//02.A large trade company has millions of articles, each described by barcode, vendor, title and price. Implement a data structure to store them 
//that allows fast retrieval of all articles in given price range [x…y]. Hint: use OrderedMultiDictionary<K,T> 
//from Wintellect's Power Collections for .NET.     

namespace _02.Company
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wintellect.PowerCollections;

    public class Program
    {
        public static void FindInRange(OrderedMultiDictionary<decimal, Article> orderedByPrice, decimal minRange, decimal maxRange)
        {
            var articles = orderedByPrice.Range(minRange, true, maxRange, true);
        }

        public static void Main(string[] args)
        {
            OrderedMultiDictionary<decimal, Article> orderedByPrice = new OrderedMultiDictionary<decimal, Article>(true);
            orderedByPrice.Add(0.75m, new Article("123456789", "Pesho Ivanov", "Milk", 0.75m));
            orderedByPrice.Add(701.00m, new Article("33513001", "Krasimira Kostova", "Laptop Asus", 701.00m));
            orderedByPrice.Add(0.15m, new Article("0011313", "Iva Ivova", "Gum", 0.15m));
            orderedByPrice.Add(1111.00m, new Article("9131333", "Kiril Petrov", "Laptop Asus", 1111.00m));
            orderedByPrice.Add(10.15m, new Article("0981313", "Ivan Ivanov", "Meat", 10.15m));
            orderedByPrice.Add(1.10m, new Article("111111", "Vasil Pavlov", "Bread", 1.10m));

            FindInRange(orderedByPrice, 1.10m, 701.00m);
        }
    }
}
