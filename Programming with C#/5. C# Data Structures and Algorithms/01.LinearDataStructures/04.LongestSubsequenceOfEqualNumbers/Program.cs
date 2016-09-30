//04.Write a method that finds the longest subsequence of equal numbers in given List<int> and returns the result as new List<int>. 
//Write a program to test whether the method works correctly.

namespace _04.LongestSubsequenceOfEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static List<int> FindLongestSubsequence(List<int> sequence)
        {
            if (sequence.Count == 0)
            {
                throw new ArgumentException("There is NO numbers in the sequence!");
            }

            int currentLength = 1;
            int maxLength = 1;
            int number = 0;

            for (int i = 0; i < sequence.Count - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    currentLength++;
                    
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        number = sequence[i];
                    }
                }
                else
                {
                    currentLength = 1;
                 }
            }

            List<int> result = new List<int>();

            // Add the longest subsequence in the new List
            if (maxLength > 1)
            {
                for (int i = 1; i <= maxLength; i++)
                {
                    result.Add(number);
                }
            }
            else
            {
                Console.WriteLine("There is NO subsequence of equal numbers!");
            }

            return result;
        }

        public static void Print(List<int> sequence)
        {
            for (int i = 0; i < sequence.Count; i++)
            {
                Console.Write(sequence[i] + " ");
            }

            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            List<int> sequence = new List<int>() { 5, 1, 11, 11, 11, 2, 1, 7, 9, 9 };
            List<int> result = FindLongestSubsequence(sequence);
            Print(result);
        }
    }
}
