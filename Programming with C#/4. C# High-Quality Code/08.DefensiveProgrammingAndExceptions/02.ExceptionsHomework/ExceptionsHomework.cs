//02.Add exception handling (where missing) and refactor all incorrect error handling in the code from the "Exceptions-Homework" 
//project to follow the best practices for using exceptions.

namespace _02.ExceptionsHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ExceptionsHomework
    {
        public static T[] Subsequence<T>(T[] array, int startIndex, int count)
        {
            if (startIndex < 0 || startIndex > array.Length)
            {
                throw new ArgumentOutOfRangeException("Start index value cannot be negative or bigger than array length!");
            }

            if (count < 0 || count > array.Length)
            {
                throw new ArgumentOutOfRangeException("Count value cannot be negative or bigger than array length!");
            }

            if (startIndex + count > array.Length)
            {
                throw new ArgumentOutOfRangeException("The array length is exceeded!");
            }

            List<T> result = new List<T>();

            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(array[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string inputString, int count)
        {
            if (inputString == string.Empty)
            {
                throw new ArgumentException("The given string value cannot be empty!");
            }

            if (inputString == null)
            {
                throw new ArgumentNullException("The given string value cannot be null!");
            }

            if (count < 0 || count > inputString.Length)
            {
                throw new ArgumentOutOfRangeException("Count value cannot be negative or bigger than value of given string!"); 
            }

            StringBuilder result = new StringBuilder();

            for (int i = inputString.Length - count; i < inputString.Length; i++)
            {
                result.Append(inputString[i]);
            }

            return result.ToString();
        }

        public static bool IsPrimeNumber(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("Invalid number!");
            }

            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Main(string[] args)
        {
            var substring = Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substring);

            var subarray = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(string.Join(" ", subarray));

            var allArray = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(string.Join(" ", allArray));

            var emptyArray = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(string.Join(" ", emptyArray));

            Console.WriteLine(ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtractEnding("Nakov", 4));
            Console.WriteLine(ExtractEnding("beer", 4));
            Console.WriteLine(ExtractEnding("Hi", 0));

            try
            {
                int firstNumber = 23;
                bool isFirstNumberPrime = IsPrimeNumber(firstNumber);
                Console.WriteLine("Is number {0} prime -> {1}", firstNumber, isFirstNumberPrime);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Number cannot be negative or zero!");
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("Source: " + ex.Source);
                Console.WriteLine("StackTrace: " + ex.StackTrace);
                Console.WriteLine("TargetSite: " + ex.TargetSite);
                Console.WriteLine();
            }

            try
            {
                int secondNumber = 33;
                bool isSecondNumberPrime = IsPrimeNumber(secondNumber);
                Console.WriteLine("Is number {0} prime -> {1}", secondNumber, isSecondNumberPrime);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Number cannot be negative or zero!");
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("Source: " + ex.Source);
                Console.WriteLine("StackTrace: " + ex.StackTrace);
                Console.WriteLine("TargetSite: " + ex.TargetSite);
                Console.WriteLine();
            }

            List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };

            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}
