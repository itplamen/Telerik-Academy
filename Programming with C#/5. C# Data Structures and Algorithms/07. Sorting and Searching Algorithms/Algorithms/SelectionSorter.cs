namespace Algorithms
{
    using System;
    using System.Collections.Generic;

    using Algorithms.Contracts;

    public class SelectionSorter<T> : ISorter<T>
        where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                var minIndex = i;

                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[j].CompareTo(collection[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    var tempElement = collection[i];
                    collection[i] = collection[minIndex];
                    collection[minIndex] = tempElement;
                }
            }

            for (int i = 0; i < collection.Count; i++)
            {
                Console.WriteLine(collection[i]);
            }
        }
    }
}
