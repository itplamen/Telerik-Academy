//05.Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
//Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. 
//Implement methods for adding element, accessing element by index, removing element by index, inserting 
//element at given position, clearing the list, finding element by its value and ToString(). Check all input parameters 
//to avoid accessing elements at invalid positions.

//06.Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.

//07.Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. 
//You may need to add a generic constraints for the type T.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GenericList
{
    class Test
    {
        static void Main(string[] args)
        {
            // ---------- Create a list of integers ---------- 
            GenericList<int> listOfIntegers = new GenericList<int>(4);

            Console.WriteLine(" ---------- Create a list of integers ---------- \n");

            // Adding elements into list and printing them
            listOfIntegers.AddElement(2);
            listOfIntegers.AddElement(3);
            listOfIntegers.AddElement(15);
            listOfIntegers.AddElement(6);

            Console.WriteLine("Print list after adding some elements: ");
            listOfIntegers.ToString();

            // Insert elements at given position
            listOfIntegers.InsertElement(2, 100);
            listOfIntegers.InsertElement(4, 91);
            
            Console.WriteLine("Print list after inserting elements at given position: ");
            listOfIntegers.ToString();

            // Find minimal and maximal element in the list and printing them
            int minIntegerElement = listOfIntegers.Min();
            int maxIntegerElement = listOfIntegers.Max();

            Console.WriteLine("The minimal element is: " + minIntegerElement);
            Console.WriteLine("The maximal element is: " + maxIntegerElement);
            Console.WriteLine();

            // Finding element by its value
            listOfIntegers.FindElementByValue(15);
            listOfIntegers.FindElementByValue(1111);

            // Remove elemnents by index and printing 
            listOfIntegers.RemoveElement(0);
            listOfIntegers.RemoveElement(2);

            Console.WriteLine("Print list after removing some elements: ");
            listOfIntegers.ToString();

            // Insert element in list by indexer and print list
            listOfIntegers[0] = 1111;

            Console.WriteLine("Print list after adding element by indexer: ");
            listOfIntegers.ToString();

            // Cleareing the list and print empty list
            listOfIntegers.ClearList();

            Console.WriteLine("Print list after clearing him: ");
            listOfIntegers.ToString();
            Console.WriteLine();

            // ---------- Create a list of strings ---------- 
            GenericList<string> listOfStrings = new GenericList<string>(5);

            Console.WriteLine(" ---------- Create a list of strings---------- \n");

            // Adding elements into list and printing them
            listOfStrings.AddElement("string");
            listOfStrings.AddElement("array");
            listOfStrings.AddElement("generic");
            listOfStrings.AddElement("list");
            listOfStrings.AddElement("build");

            Console.WriteLine("Print list after adding some elements: ");
            listOfStrings.ToString();

            // Insert elements at given position
            listOfStrings.InsertElement(1, "project");
            listOfStrings.InsertElement(3, "help");

            Console.WriteLine("Print list after inserting elements at given position: ");
            listOfStrings.ToString();

            // Find minimal and maximal element in the list and printing them
            string minStringElement = listOfStrings.Min();
            string maxStringElement = listOfStrings.Max();

            Console.WriteLine("The minimal element is: " + minStringElement);
            Console.WriteLine("The maximal element is: " + maxStringElement);
            Console.WriteLine();

            // Finding element by its value
            listOfStrings.FindElementByValue("help");
            listOfStrings.FindElementByValue("windows");

            // Remove elemnents by index and printing 
            listOfStrings.RemoveElement(0);
            listOfStrings.RemoveElement(2);

            Console.WriteLine("Print list after removing some elements: ");
            listOfStrings.ToString();

            // Insert element in list by indexer and print list
            listOfStrings[2] = "architecture";

            Console.WriteLine("Print list after adding element by indexer: ");
            listOfStrings.ToString();

            // Cleareing the list and print empty list
            listOfStrings.ClearList();

            Console.WriteLine("Print list after clearing him: ");
            listOfStrings.ToString();
        }
    }
}
