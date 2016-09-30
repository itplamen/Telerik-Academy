//01.Refactor the following examples to produce code with well-named C# identifiers:

namespace _01.RefactorExamples
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        private const int MAX_COUNT = 6;

        public static void Main(string[] args)
        {
            PrintBoolean currentBolean = new PrintBoolean();
            currentBolean.PrintGivenBoolean(true);
        }

        public class PrintBoolean
        {
            public void PrintGivenBoolean(bool booleanVariable)
            {
                string convertedBoolean = booleanVariable.ToString();
                Console.WriteLine(convertedBoolean);
            }
        }
    }
}
