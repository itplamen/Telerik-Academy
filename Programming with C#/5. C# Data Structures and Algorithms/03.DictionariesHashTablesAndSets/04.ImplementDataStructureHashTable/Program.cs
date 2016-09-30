// 04.Implement the data structure "hash table" in a class HashTable<K,T>. Keep the data in array of lists of key-value pairs 
// (LinkedList<KeyValuePair<K,T>>[]) with initial capacity of 16. When the hash table load runs over 75%, perform resizing to 2 times larger 
// capacity. Implement the following methods and properties: Add(key, value), Find(key)value, Remove(key), Count, Clear(), this[], Keys. 
// Try to make the hash table to support iterating over its elements with foreach.

namespace _04.ImplementDataStructureHashTable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> keys = new List<string>()
            {
                "JAVA", "JavaScript", "HTML", "CSS", "mono", "ado.net", ".net", "cts", "clr", "C#", 
                "c", "c++", "IL", 
            };

            List<int> values = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            HashTable<string, int> hashTable = new HashTable<string, int>();

            for (int i = 0; i < keys.Count; i++)
            {
                hashTable.Add(keys[i], values[i]);
            }

            Console.WriteLine("---------- PRINT ELEMENTS ----------");
            foreach (var pair in hashTable)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }

            Console.WriteLine();

            Console.WriteLine("---------- TRY TO ADD EXIST KEY ----------");
            try
            {
                hashTable.Add("CSS", 71);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }

            Console.WriteLine("---------- PRINT COUNT AND CAPACITY ----------");
            Console.WriteLine("Count = {0}, Capacity = {1}", hashTable.Count, hashTable.Capacity);
            Console.WriteLine();

            var listOfKeys = hashTable.Keys;
            Console.WriteLine("---------- PRINT KEYS ----------");
            for (int i = 0; i < listOfKeys.Count; i++)
            {
                Console.Write(listOfKeys[i] + " ");
            }

            Console.WriteLine("\n");

            var listOfValues = hashTable.Values;
            Console.WriteLine("---------- PRINT VALUES ----------");
            for (int i = 0; i < listOfValues.Count; i++)
            {
                Console.Write(listOfValues[i] + " ");
            }

            Console.WriteLine("\n");

            Console.WriteLine("---------- PRINT ELEMENT BY INDEXER ----------");
            Console.WriteLine("C# -> {0}", hashTable["C#"]);
            Console.WriteLine();

            // Add new key and value by indexer.
            hashTable["Google"] = 713;

            Console.WriteLine("---------- CHECK IF KEY AND VALUE EXIST ----------");
            Console.WriteLine("Is key exist: {0}, Is value exist: {1}", hashTable.ContainsKey("Google"), hashTable.ContainsValue(713));
            Console.WriteLine();

            // Overwrite key's value.
            hashTable["Google"] = 111;

            Console.WriteLine("---------- PRINT ELEMENT BY INDEXER ----------");
            Console.WriteLine("Google -> {0}", hashTable["Google"]);
            Console.WriteLine();

            Console.WriteLine("---------- FIND SPECIFIED KEY AND VALUE ----------");
            Console.WriteLine("HTML -> {0}", hashTable.Find("HTML"));
            Console.WriteLine();

            Console.WriteLine("---------- TRY TO FIND NEVALID KEY ----------");
            try
            {
                hashTable.Find("Windows");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }

            // Remove element.
            hashTable.Remove("Google");
            Console.WriteLine("---------- CHECK IF KEY AND VALUE EXIST ----------");
            Console.WriteLine("Is key exist: {0}, Is value exist: {1}", hashTable.ContainsKey("Google"), hashTable.ContainsValue(713));
            Console.WriteLine();

            Console.WriteLine("---------- TRY TO REMOVE NEVALID KEY ----------");
            try
            {
                hashTable.Remove("Windows");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }

            Console.WriteLine("---------- TRY TO FIND NULL KEY ----------");
            try
            {
                hashTable.ContainsKey(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }

            hashTable.Clear();
        }
    }
}
