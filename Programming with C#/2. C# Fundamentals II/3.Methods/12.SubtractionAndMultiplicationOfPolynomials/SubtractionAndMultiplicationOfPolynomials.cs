//12.Extend the program to support also subtraction and multiplication of polynomials.

using System;

class SubtractionAndMultiplicationOfPolynomials
{
    static int[] SubtractPolynomals(int[] firstPolynomial, int[] secondPolynomial)
    {
        int[] result;

        if (firstPolynomial.Length < secondPolynomial.Length)
        {
            result = new int[secondPolynomial.Length];
            for (int i = 0; i < secondPolynomial.Length; i++)
            {
                if (i >= firstPolynomial.Length)
                {
                    result[i] = secondPolynomial[i] * -1;
                    continue;
                }
                result[i] = firstPolynomial[i] - secondPolynomial[i];
            }
        }

        else
        {
            result = new int[firstPolynomial.Length];
            for (int i = 0; i < firstPolynomial.Length; i++)
            {
                if (i >= secondPolynomial.Length)
                {
                    result[i] = firstPolynomial[i] * -1;
                    continue;
                }
                result[i] = firstPolynomial[i] - secondPolynomial[i];
            }
        }
        return result;
    }

    public static int[] MultiplicatePolynomals(int[] first, int[] second)
    {
        int biggestPower = (first.Length - 1) * (second.Length - 1);
        int[] result = new int[biggestPower];

        for (int i = 0; i < first.Length; i++)
        {
            for (int j = 0; j < second.Length; j++)
            {
                int power = i + j;
                result[power] += first[i] * second[j];
            }
        }
        return result;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter length of first polinomial: ");
        int firstPolynomialsLength = int.Parse(Console.ReadLine());

        int[] firstPolynomial = new int[firstPolynomialsLength];

        for (int i = 0; i < firstPolynomialsLength; i++)
        {
            Console.Write("Enter number: ");
            firstPolynomial[i] = int.Parse(Console.ReadLine());
        }

        //Secon polynomial
        Console.Write("Enter length of second polynomial: ");
        int secondPolynomialsLength = int.Parse(Console.ReadLine());

        int[] secondPolynomial = new int[secondPolynomialsLength];

        for (int i = 0; i < secondPolynomialsLength; i++)
        {
            Console.Write("Enter number: ");
            secondPolynomial[i] = int.Parse(Console.ReadLine());
        }

        int[] result = SubtractPolynomals(firstPolynomial, secondPolynomial);

        Console.Write("Polynomal 1 - Polynomal 2: ");
        for (int i = result.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                Console.WriteLine(result[i]);
                break;
            }
            if (result[i] != 0) Console.Write("(" + result[i] + ")" + "x" + i + " + ");
        }

        result = MultiplicatePolynomals(firstPolynomial, secondPolynomial);

        Console.Write("Polynomal 1 x Polynomal 2: ");
        for (int i = result.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                Console.WriteLine(result[i]);
                break;
            }
            if (result[i] != 0) Console.Write("(" + result[i] + ")" + "x" + i + " + ");
        }
    }

}