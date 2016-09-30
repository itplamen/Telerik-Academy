namespace Algorithms
{
    using System;
    using System.Collections.Generic;

    using Algorithms.Contracts;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            this.Quicksort(collection);
        }

        private IList<T> Quicksort(IList<T> collection)
        {
            if (collection.Count <= 1)
            {
                return collection;
            }

            return null;
        }
    }
}
