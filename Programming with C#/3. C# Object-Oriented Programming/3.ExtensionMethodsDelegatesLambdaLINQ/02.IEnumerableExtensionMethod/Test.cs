//02.Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
//sum, product, min, max, average.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerableExtensionMethod
{
    class Test
    {
        static void Main(string[] args)
        {
            IEnumerable<int> array = new int []{ 1, 2, 5, 7, 11, 100, 12, 3, -4 };

            Console.WriteLine("The sum is: " + array.SumExtension<int>());
            Console.WriteLine("The product is: " + array.ProductExtension<int>());
            Console.WriteLine("The min element is: " + array.MinExtension<int>());
            Console.WriteLine("The max element is: " + array.MaxExtension<int>());
            Console.WriteLine("The average is: " + array.AverageExtension<int>());
        }
    }
}
