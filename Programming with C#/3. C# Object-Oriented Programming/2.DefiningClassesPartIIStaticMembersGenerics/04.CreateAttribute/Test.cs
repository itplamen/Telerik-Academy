//11.Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in 
//the format major.minor (e.g. 2.11). Apply the version attribute to a sample class and display its version at runtime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CreateAttribute
{
    class Test
    {
        static void Main(string[] args)
        {
            Type type = typeof(Laptop);

            foreach (VersionAttribute attr in type.GetCustomAttributes(false))
            {
                if (attr is VersionAttribute)
                {
                    Console.WriteLine("This is version {0} of the Laptop class.", (attr as VersionAttribute).Version);
                }
            }
        }
    }
}
