//13.Implement the ADT queue as dynamic linked list. Use generics (LinkedQueue<T>) to allow storing different data types in 
//the queue.

namespace _13.ImplementADTQueueAsDynamicLinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LinkedQueueExample
    {
        public static void Main(string[] args)
        {
            LinkedQueue<int> linkedQueue = new LinkedQueue<int>();
            linkedQueue.Enqueue(1);
            linkedQueue.Enqueue(2);
            linkedQueue.Enqueue(3);
            linkedQueue.Enqueue(4);
            linkedQueue.Enqueue(5);
            linkedQueue.Enqueue(6);

            Console.WriteLine("Print queue elements: " + linkedQueue + "\n");
            Console.WriteLine("Print number of queue elements: " + linkedQueue.Count + "\n");

            var elementFromQueue = 5;
            Console.WriteLine("Is queue contains element {0}: {1}", elementFromQueue, linkedQueue.Contains(elementFromQueue) + "\n");

            var someElement = -17;
            Console.WriteLine("Is queue contains element {0}: {1}", someElement, linkedQueue.Contains(someElement) + "\n");

            var array = linkedQueue.ToArray();
            Console.Write("Print array elements: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Print first element without removing it: " + linkedQueue.Peek() + "\n");

            Console.WriteLine("Print and remove first element: " + linkedQueue.Dequeue() + "\n");
            
            Console.WriteLine("Print elements after removed the first one: " + linkedQueue + "\n");

            linkedQueue.Clear();
            Console.WriteLine("Print elements after removed them all: " + linkedQueue + "\n");
        }
    }
}
