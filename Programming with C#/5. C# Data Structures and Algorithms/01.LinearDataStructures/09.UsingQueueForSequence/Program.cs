//09.We are given the following sequence:
//S1 = N;
//S2 = S1 + 1;
//S3 = 2*S1 + 1;
//S4 = S1 + 2;
//S5 = S2 + 1;
//S6 = 2*S2 + 1;
//S7 = S2 + 2;
//...
//Using the Queue<T> class write a program to print its first 50 members for given N.
//Example: N=2  2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...

namespace _09.UsingQueueForSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        private const int NUMBER_OF_MEMBERS = 50;
        private const int COUNTER = 17;

        public static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            Queue<int> sequenceMembers = new Queue<int>();
            sequenceMembers.Enqueue(n);

            for (int i = 1; i <= NUMBER_OF_MEMBERS; i++)
            {
                int number = sequenceMembers.Dequeue();
                Console.WriteLine("S{0} = {1}", i, number);

                // This is for that we dont calculate and enqueue unnecessary elements.
                if (i <= COUNTER)
                {
                    sequenceMembers.Enqueue(number + 1);
                    sequenceMembers.Enqueue((2 * number) + 1);
                    sequenceMembers.Enqueue(number + 2);
                }     
            }
        }
    }
}
