//01.Implement an extension method Substring(int index, int length) for the class StringBuilder that returns 
//new StringBuilder and has the same functionality as Substring in the class String.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringBuilderExtensionMethod
{
    class Test
    {
        static void Main(string[] args)
        {
            // Testing with Substing method in StringBuilder class
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello Telerik Academy");
            Console.WriteLine(sb.Substring(3, 9));
        }
    }
}
