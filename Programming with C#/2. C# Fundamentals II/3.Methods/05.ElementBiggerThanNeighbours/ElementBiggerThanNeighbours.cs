//05.Write a method that checks if the element at given position in given array of integers is bigger than its two 
//neighbors (when such exist).

using System;

class CheckElement
{
    static void Check(int[] array, int position)
    {
        if (array.Length == 1)
        {
            Console.WriteLine("The element has no neighbors");
        }
        else
        {
            if (position == 0)
            {
                Console.WriteLine("The comparable numbers are {0} and {1}", array[position], array[position + 1]);
                Console.WriteLine("The bigger number is: " + Math.Max(array[position], array[position + 1]));
            }
            else if (position == array.Length - 1)
            {
                Console.WriteLine("The comparable numbers are {0} and {1}", array[position], array[position - 1]);
                Console.WriteLine("The bigger number is: " + Math.Max(array[position], array[position - 1]));
            }
            else if ((position > 0) && (position < array.Length - 1))
            {
                Console.WriteLine("The comparable numbers are {0}, {1} and {2}", array[position], array[position + 1], array[position - 1]);
                Console.WriteLine("The bigger number is: " + Math.Max(Math.Max(array[position], array[position + 1]), array[position - 1]));
            }
            else
            {
                Console.WriteLine("There is no such number in this position. Try again... ");
                Main();
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter array length: ");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] array = new int[arrayLength];

        Console.WriteLine("Enter array elements ...");
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Position [{0}] -> ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter element position you want to check: ");
        int position = int.Parse(Console.ReadLine());

        Check(array, position);
    }
}

