//Refactor the C# code from the Visual Studio Project "Refactoring-Homework.zip" to improve its internal quality. 
//You might follow the following steps:

//01. Make some initial refactorings like:
//-Reformat the code.
//-Rename the ugly named variables.

//02. Make the code testable.
//-Think how to test console-based input / output.

//03. Write unit tests. Fix any bugs found in the mean time.

//04. Refactor the code following the guidelines from this chapter. Do it step by step. Run the unit tests after 
//each major change.

namespace MatrixRotatingWalk
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MatrixExample
    {
        private const int MIN_DIMENSION_SIZE = 1;
        private const int MAX_DIMENSION_SIZE = 100;

        private static void Main(string[] args)
        {
            Console.Write("Enter matrix dimension (must be positive numeber!): ");
            int dimension = int.Parse(Console.ReadLine());

            while (dimension < MIN_DIMENSION_SIZE || dimension > MAX_DIMENSION_SIZE)
            {
                Console.Write("You haven't entered a correct matrix dimension. Try again... : ");
                dimension = int.Parse(Console.ReadLine());
            }

            FillMatrix matrix = new FillMatrix(dimension);
            matrix.FillMatrixWithNumbers();
            Console.WriteLine(matrix);
        }
    }
}
