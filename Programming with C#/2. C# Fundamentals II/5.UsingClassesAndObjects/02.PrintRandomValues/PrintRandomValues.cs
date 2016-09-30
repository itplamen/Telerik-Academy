//02. Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

    class PrintRandomValues
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            for (int numbers = 1; numbers <= 10; numbers++)
            {
                Console.WriteLine("{0} -> {1}", numbers, rand.Next(200) + 100);
            }
        }
    }

