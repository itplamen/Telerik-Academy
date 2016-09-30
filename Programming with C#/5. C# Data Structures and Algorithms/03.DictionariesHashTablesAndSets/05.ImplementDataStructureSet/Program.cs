//05. Implement the data structure "set" in a class HashedSet<T> using your class HashTable<K,T> to hold the elements. Implement all 
//standard set operations like Add(T), Find(T), Remove(T), Count, Clear(), union and intersect.

namespace _05.ImplementDataStructureSet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using _04.ImplementDataStructureHashTable;

    public class Program
    {
        public static void Main(string[] args)
        {
            HashedSet<string> hashedSet = new HashedSet<string>();
            hashedSet.Add("C++");
            hashedSet.Add("Java");
            hashedSet.Add("C");
            hashedSet.Add("Java");
            hashedSet.Add("Java");

            Console.WriteLine("---------- PRINT ELEMENTS ----------");
            foreach (var item in hashedSet)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n");

            string firstElement = "Pascal";
            Console.WriteLine("Is hash set contains element \"{0}\": {1}", firstElement, hashedSet.Contains(firstElement));

            string secondElement = "Java";
            Console.WriteLine("Is hash set contains element \"{0}\": {1}", secondElement, hashedSet.Contains(secondElement) + "\n");

            string firstElementForRemoving = "F#";
            Console.WriteLine("Is element \"{0}\" removed: {1}", firstElementForRemoving, hashedSet.Remove(firstElementForRemoving));

            string secondElementForRemoving = "C";
            Console.WriteLine("Is element \"{0}\" removed: {1}", secondElementForRemoving, hashedSet.Remove(secondElementForRemoving));

            HashedSet<string> newHashedSet = new HashedSet<string>();
            newHashedSet.Add("Php");
            newHashedSet.Add("SQL");
            newHashedSet.Add("Java");
            newHashedSet.Add("C");

            hashedSet.Union(newHashedSet);
            Console.WriteLine("---------- PRINT ELEMENTS AFTER UNION ----------");
            foreach (var item in hashedSet)
            {
                Console.WriteLine(item);
            }

            hashedSet.Remove("Php");
            hashedSet.Remove("SQL");

            newHashedSet.Intersect(hashedSet);
            Console.WriteLine("---------- PRINT ELEMENTS AFTER INTERSECT ----------");
            foreach (var item in newHashedSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
