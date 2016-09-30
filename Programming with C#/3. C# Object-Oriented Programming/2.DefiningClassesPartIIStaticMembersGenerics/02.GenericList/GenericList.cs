using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GenericList
{
    // Declaring a generic class GenericList<T> with generic constraint IComparable<T>
    public class GenericList<T>
        where T : IComparable<T>
    {
        // Fields
        private T[] array;
        private int count = 0;

        // Constructor
        public GenericList(int size)
        {
            if (size >= 0)
            {
                this.array = new T[size];
            }
            else
            {
                throw new ArgumentOutOfRangeException(String.Format("Negative array size!"));
            }
        }

        // ----- METHODS -----
        // Defining an indexer
        public T this[int index]
        {
            get
            {
                if (index > array.Length || index < 0)
                {
                    throw new IndexOutOfRangeException(String.Format("Index {0} is invalid!", index));
                }
                else
                {
                    return this.array[index];
                }
            }
            set
            {
                if (index > array.Length || index < 0)
                {
                    throw new IndexOutOfRangeException(String.Format("Index {0} is invalid!", index));
                }
                else
                {
                    this.array[index] = value;
                }
            }
        }

        // Add elements into array
        public void AddElement(T element)
        {
            if (count >= array.Length)
            {
                DoublingArray();
            }

            array[count] = element;
            count++;
        }
        
        // Remove elements by index
        public void RemoveElement(int index)
        {
            try
            {
                if (index <= array.Length || index >= 0)
                {
                    T[] tempArray = new T[array.Length - 1];
                    int tempIndex = 0;

                    for (int i = 0; i < array.Length; i++)
                    {
                        if (i != index)
                        {
                            tempArray[tempIndex] = array[i];
                            tempIndex++;
                        }
                    }

                    array = tempArray;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index {0} is not accesible! Index out of range");
            }
        }

        // Insert element at given position
        public void InsertElement(int index, T element)
        {
            try
            {
                T[] tempArray = new T[array.Length + 1];
                int tempIndex = 0;

                if (index <= array.Length || index >= 0)
                {
                    for (int i = 0; i < tempArray.Length; i++)
                    {
                        if (i == index)
                        {
                            tempArray[i] = element;
                        }
                        else
                        {
                            tempArray[i] = array[tempIndex];
                            tempIndex++;    
                        }
                    }

                    array = tempArray;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index {0} is not accesible! Index out of range");
            }
        }

        // Find element by its value
        public void FindElementByValue(T elementValue)
        {
            if (array.Length == 0)
            {
                throw new Exception("The list is empty!");
            }
            else
            {
                bool check = false;

                for (int i = 0; i < array.Length; i++)
                {
                    if (elementValue.CompareTo(array[i]) == 0)
                    {
                        Console.WriteLine("The index of the value \"{0}\" is {1}" ,elementValue, i);
                        check = true;
                    }
                }

                if (check == false)
                {
                    Console.WriteLine("There is no such value \"{0}\" in the list!" ,elementValue);
                    Console.WriteLine();
                }
            }
        }

        // Clear the list
        public void ClearList()
        {
            array = new T[0];
        }

        // Override ToString()
        public override string ToString()
        {
            // Checking if method ClearList() was doing his job
            bool check = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                {
                    check = true;
                }
            }

            if (check == false)
            {
                Console.WriteLine("The list is empty!\n");
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("\"{0}\" ", array[i]);
                }

                Console.WriteLine("\n");
            }

            return base.ToString();
        }

        // Doubling array legth
        private void DoublingArray()
        {
            T[] tempArray = new T[array.Length * 2];
            Array.Copy(array, tempArray, array.Length);
            array = tempArray;
        }

        // Finding minimal element
        public T Min()
        {
            if (array.Length == 0)
            {
                throw new Exception("The list is empty!");
            }
            else if (array.Length == 1)
            {
                return array[0];
            }
            else
            {
                T minElement = array[0];

                for (int i = 1; i < array.Length; i++)
                {
                    if (minElement.CompareTo(array[i]) > 0)
                    {
                        minElement = array[i];
                    }
                }

                return minElement;
            }
        }

        // Finding maximal element
        public T Max()
        {
            if (array.Length == 0)
            {
                throw new Exception("The list is empty!");
            }
            else if (array.Length == 1)
            {
                return array[0];
            }
            else
            {
                T maxElement = array[0];

                for (int i = 1; i < array.Length; i++)
                {
                    if (maxElement.CompareTo(array[i]) < 0)
                    {
                        maxElement = array[i];
                    }
                }

                return maxElement;
            }
        }
    }
}
