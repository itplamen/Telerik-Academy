//8.Declare two string variables and assign them with following value:
//The "use" of quotations causes difficulties.
//Do the above in two different ways: with and without using quoted strings.

using System;

class DeclareTwoString
{
    static void Main(string[] args)
    {
        String s1 = "The \"use\" of quotations causes difficulties.";
        String s2 = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine("First variant: " + s1);
        Console.WriteLine("Second variant: " + s2);
    }
}

