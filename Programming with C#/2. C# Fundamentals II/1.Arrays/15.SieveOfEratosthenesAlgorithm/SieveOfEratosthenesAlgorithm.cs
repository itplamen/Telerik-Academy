//15. Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;

  class SieveOfEratosthenesAlgorithm
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array legth:");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] array = new int[arrayLength];
            int max = (int)Math.Sqrt(arrayLength);

            for (int i = 2; i < max; i++)
            {
                if (array[i] == 0)
                {
                    for (int m = (i * i); m < arrayLength; m += i)
                    {
                        array[m] = 1;
                    }
                }
            }

            for (int i = 2; i < arrayLength; i++)
            {
                if (array[i] == 1) continue;
                if (i > 2) Console.Write(",");
                Console.Write("{0}", i);
            }
            Console.WriteLine("");
        }
    }

