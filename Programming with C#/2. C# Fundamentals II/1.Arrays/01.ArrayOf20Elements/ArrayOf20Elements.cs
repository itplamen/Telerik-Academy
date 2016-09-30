//01.Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
//Print the obtained array on the console.

using System;

    class ArrayOf20Elements
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Index {0} -> element {1}", i, array[i] = i * 5);
            }
           
        }
    }

