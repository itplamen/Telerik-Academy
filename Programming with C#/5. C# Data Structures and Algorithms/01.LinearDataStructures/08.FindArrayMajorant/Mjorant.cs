//08. * The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times. Write a program to find the majorant of given array (if exists). Example:
//{2, 2, 3, 3, 2, 3, 4, 3, 3}  3

namespace _08.FindArrayMajorant
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Mjorant
    {
        public static void Main(string[] args)
        {
            int[] array = { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            Array.Sort(array);

            int counter = 1;
            int majorant = (array.Length / 2) + 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter == majorant)
                {
                    Console.WriteLine("Majorant is: " + array[i]);
                    break;
                }
            }

            if (counter != majorant)
            {
                Console.WriteLine("There is no majorant!");
            }
        }
    }
}
