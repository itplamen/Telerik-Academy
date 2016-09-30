//7.Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it 
//with the concatenation of the first two variables (mind adding an interval). Declare a third string variable and 
//initialize it with the value of the object variable (you should perform type casting).

using System;

class DeclareObject
{
    static void Main(string[] args)
    {
        string s1 = "Hello";
        string s2 = "World!";

        object concat = s1 + " " + s2;
        string s3 = (string)concat;

        Console.WriteLine(s3);
    }
}

