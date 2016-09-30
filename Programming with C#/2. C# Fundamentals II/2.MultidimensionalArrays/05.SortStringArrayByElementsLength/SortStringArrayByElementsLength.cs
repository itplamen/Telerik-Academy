//05.You are given an array of strings. Write a method that sorts the array by the length of its elements 
//(the number of characters composing them).

using System;

    class SortStringArrayByElementsLength
    {
        static void SortBySize(string[] array)
        {
            int[] sizes = new int[array.Length];              

            for (int i = 0; i < array.Length; i++)
            {
                sizes[i] = array[i].Length;
            }

            Array.Sort(sizes, array);  
     
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }
        static void Main(string[] args)
        {
            string[] stringArray = { "horse", "cat", "mouse", "frog", "dog"};

            SortBySize(stringArray);
        }
    }

