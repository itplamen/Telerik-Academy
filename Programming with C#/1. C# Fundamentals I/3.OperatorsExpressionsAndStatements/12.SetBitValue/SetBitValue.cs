//12.We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to 
//hold the value v at the position p from the binary representation of n.
	
//Example: n = 5 (00000101), p=3, v=1  13 (00001101)
//         n = 5 (00000101), p=2, v=0  1 (00000001)

using System;

class SetBitValue
{
    static void Main(string[] args)
    {
        Console.Write("Enter integer number n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter position p: ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Enter value (v=0 or 1): ");
        int v = int.Parse(Console.ReadLine());

        int mask = 1 << p;

        Console.WriteLine("Number's value is: {0}", n);
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

        if (v == 0)
        {
            n = n & ~(mask);
            Console.WriteLine("Number's new value is: {0}", n);
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        }
        else
        {
            n = n | mask;
            Console.WriteLine("Number's new value is: {0}", n);
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        }  
    }
}

