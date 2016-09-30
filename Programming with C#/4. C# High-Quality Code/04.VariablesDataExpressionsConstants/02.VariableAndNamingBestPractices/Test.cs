//02. Refactor the following code to apply variable usage and naming best practices:

namespace _02.VariableAndNamingBestPractices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Test
    {
        public static void Main(string[] args)
        {
            Test test = new Test();
            double[] sequence = {1.1, 22.22, 3.0, 0.0001, 16.999 };

            double maxNumber = test.CalculateMaxNumber(sequence);
            double minNumber = test.CalculateMinNumber(sequence);
            double averageNumber = test.CalculateAverageNumber(sequence);

            test.PrintStatistics(maxNumber, minNumber, averageNumber);
        }

        private double CalculateMaxNumber(double[] sequence)
        {
            double maxNumber = sequence[0];

            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] > maxNumber)
                {
                    maxNumber = sequence[i];
                }
            }

            return maxNumber;
        }

        private double CalculateMinNumber(double[] sequence)
        {
            double minNumber = sequence[0];

            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] < minNumber)
                {
                    minNumber = sequence[i];
                }
            }

            return minNumber;
        }

        private double CalculateAverageNumber(double[] sequence)
        {
            double sum = 0.0;

            for (int i = 0; i < sequence.Length; i++)
            {
                sum += sequence[i];
            }

            double averageNumber = sum / sequence.Length;

            return averageNumber;
        }

        private void PrintStatistics(double maxNumber, double minNumber, double averageNumber)
        {
            Console.WriteLine("Max number: " + maxNumber);
            Console.WriteLine("Min number: " + minNumber);
            Console.WriteLine("Average number: " + averageNumber);
        }
    }
}
