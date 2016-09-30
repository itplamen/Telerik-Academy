//06.Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, 
//if there’s no such element. Use the method from the previous exercise.

using System;

    class FirstElementBiggerThanNeighbours
    {
        static void Check(int[] array)
        {
            int firstBigIndex = 0;
            for (int index = 1; index < array.Length - 1; index++)
            {
                int firstBig = array[index];
                if ((firstBig > array[index + 1]) && (firstBig > array[index - 1]))
                {
                    firstBigIndex = index;
                    break;
                }
                else
                {
                    firstBigIndex = -1;
                }    
            }
            Console.WriteLine("The index is: " + firstBigIndex);   
        }
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] array = new int[arrayLength];

            Console.WriteLine("Enter array elements");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("[{0}] -> ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Check(array);
        }
    }

