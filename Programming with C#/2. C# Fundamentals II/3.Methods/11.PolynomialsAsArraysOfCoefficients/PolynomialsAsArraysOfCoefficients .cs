//11.Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
// x2 + 5 = 1x2 + 0x + 5  501

using System;

    class PolynomialsAsArraysOfCoefficients 
    {
        static int[] AddPolynomals(int[] firstPolynomial, int[] secondPolynomial)
        {
            int[] result;

            if (firstPolynomial.Length < secondPolynomial.Length)
            {
                result = new int[secondPolynomial.Length];
                for (int i = 0; i < secondPolynomial.Length; i++)
                {
                    if (i >= firstPolynomial.Length)
                    {
                        result[i] = secondPolynomial[i];
                        continue;
                    }
                    result[i] = firstPolynomial[i] + secondPolynomial[i];
                }
            }

            else
            {
                result = new int[firstPolynomial.Length];
                for (int i = 0; i < firstPolynomial.Length; i++)
                {
                    if (i >= secondPolynomial.Length)
                    {
                        result[i] = firstPolynomial[i];
                        continue;
                    }
                    result[i] = firstPolynomial[i] + secondPolynomial[i];
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

            //Result of the two polynomials
            int[] result = AddPolynomals(firstPolynomial, secondPolynomial);

            Console.Write("Result: ");
            for (int i = result.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine(result[i]);
                    break;
                }
                if (result[i] != 0) Console.Write(result[i] + "x" + i + " + ");
            }
        }
    }

