namespace _05.ImplementDataStructureSet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using _04.ImplementDataStructureHashTable;

    public class HashedSet<T> : IEnumerable<T>
    {
        private const bool VALUE = true;
        private const int INITIAL_CAPACITY = 16;
        private HashTable<T, bool> hashSet;

        public HashedSet()
        {
            this.hashSet = new HashTable<T, bool>(INITIAL_CAPACITY);
        }

        /// <summary>
        /// Returns the capacity of the hash set.
        /// </summary>
        public int Capacity 
        {
            get
            {
                return this.hashSet.Capacity;
            } 
        }

        /// <summary>
        /// Returns the number ot the elements in the hash set.
        /// </summary>
        public int Count 
        {
            get
            {
                return this.hashSet.Count;
            }
        }

        /// <summary>
        /// Appends an element to the set. Does nothing if the element already exist.
        /// </summary>
        /// <param name="element">The element you want to add.</param>
        /// <returns>True  - if elements is added to the hash set. False - if the element is already present.</returns>
        /// <exception cref="System.ArgumentException">
        /// Invalid element.
        /// </exception>
        public bool Add(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Element cannot be null!");
            }

            if (this.Contains(element))
            {
                return false;
            }

            this.hashSet.Add(element, VALUE);
            return true;
        }

        /// <summary>
        /// Checks whether the hash set contains given element.
        /// </summary>
        /// <param name="element">The element you want to check.</param>
        /// <returns>True - if the hash set contais the given element. False - if not.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// Invalid element.
        /// </exception>
        public bool Contains(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Element cannot be null!");
            }

            if (element == null)
            {
                throw new ArgumentNullException("Element cannot be null!");
            }

            return this.hashSet.ContainsKey(element);
        }

        /// <summary>
        /// Removes given element.
        /// </summary>
        /// <param name="element">The element you want to remove.</param>
        /// <returns>True - if the element is found and removed. False - if not.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// Invalid element.
        /// </exception>
        public bool Remove(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Element cannot be null!");
            }

            if (!this.Contains(element))
            {
                return false;
            }

            this.hashSet.Remove(element);
            return true;
        }

        /// <summary>
        /// Remove all elements.
        /// </summary>
        public void Clear()
        {
            this.hashSet = new HashTable<T, bool>(INITIAL_CAPACITY);
        }

        /// <summary>
        /// Performs union with another set.
        /// </summary>
        /// <param name="other">The another set.</param>
        public void Union(HashedSet<T> other)
        {
            foreach (var item in other.hashSet)
            {
                if (!this.Contains(item.Key))
                {
                    this.Add(item.Key);
                }
            }
        }

        /// <summary>
        /// Performs intersection with another set.
        /// </summary>
        /// <param name="other">The another set.</param>
        public void Intersect(HashedSet<T> other)
        {
            List<T> elementsForRemoving = new List<T>();

            foreach (var item in this.hashSet)
            {
                if (!other.Contains(item.Key))
                {
                    elementsForRemoving.Add(item.Key);
                }
            }

            // Remove elements
            for (int i = 0; i < elementsForRemoving.Count; i++)
            {
                this.Remove(elementsForRemoving[i]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.hashSet)
            {
                yield return item.Key;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
