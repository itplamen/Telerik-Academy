//11.Implement the data structure linked list. Define a class ListItem<T> that has two fields: value (of type T) and NextItem 
//(of type ListItem<T>). Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).

namespace _11.ImplementDataStructureLinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LinkedListExample
    {
        public static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.Add(5);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(6);
            linkedList.Add(4);
            linkedList.Add(7);
            linkedList.Add(1);
            Console.WriteLine("Print number of list elements: " + linkedList.Count + "\n");
            Console.Write("Print list elements: " + linkedList + "\n");

            linkedList.Reverse();
            Console.Write("After reverse: " + linkedList + "\n");

            linkedList.Sort();
            Console.Write("After sort: " + linkedList + "\n\n");

            linkedList.Insert(0, 33);
            Console.Write("Add element to the head: " + linkedList + "\n");

            linkedList.Insert(3, 66);
            Console.Write("Add element in the middle: " + linkedList + "\n");

            linkedList.Insert(linkedList.Count - 1, 99);
            Console.Write("Add element at the end: " + linkedList + "\n\n");

            linkedList.RemoveAt(0);
            Console.Write("Remove first element: " + linkedList + "\n");

            linkedList.RemoveAt(2);
            Console.Write("Remove middle element: " + linkedList + "\n");

            linkedList.RemoveAt(linkedList.Count - 1);
            Console.Write("Remove last element: " + linkedList + "\n\n");

            int numberFromList = 5;
            bool isElementRemoved = linkedList.Remove(numberFromList);
            Console.Write("Removes the first occurrence of element {0}: {1}", numberFromList, linkedList + "\n");
            Console.WriteLine("Is element removed: " + isElementRemoved + "\n");

            int someNumber = 93;
            bool isOtherElementRemoved = linkedList.Remove(someNumber);
            Console.Write("Removes the first occurrence of element {0}: {1}", someNumber, linkedList + "\n");
            Console.WriteLine("Is element removed: " + isOtherElementRemoved + "\n");

            int numberInList = 3;
            Console.WriteLine("Is list contains number {0}: {1}", numberInList, linkedList.Contains(numberInList));

            int differenNumber = 9;
            Console.WriteLine("Is list contains number {0}: {1}", differenNumber, linkedList.Contains(differenNumber) + "\n");

            int numberWithValidIndex = 4;
            Console.WriteLine("Index of the number {0} is: {1}", numberWithValidIndex, linkedList.IndexOf(numberWithValidIndex));

            int numberWithInvalidIndex = 8;
            Console.WriteLine("Index of the number {0} is: {1}", numberWithInvalidIndex, linkedList.IndexOf(numberWithInvalidIndex) + "\n");

            linkedList[0] = -21;
            Console.WriteLine("Direct access the list by index: " + linkedList);

            int index = 4;
            Console.WriteLine("Number at the index {0} is: {1}", index, linkedList[index]);

            var array = linkedList.ToArray();
            Console.Write("Print array elements: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Print elements with foreach loop");
            foreach (var item in linkedList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n");
          
            linkedList.Clear();
            Console.WriteLine("Print list afret remove all elements: " + "\n");
        }
    }
}
