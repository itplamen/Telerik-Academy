namespace _11.ImplementDataStructureLinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LinkedList<T> : IEnumerable<T>
    {
        private class ListItem<U>
        {
            private U value;
            private ListItem<U> next;

            public ListItem(U value)
            {
                this.Value = value;
                this.Next = null;
            }

            public ListItem(U value, ListItem<U> prev)
            {
                this.Value = value;
                prev.Next = this;
            }

            public U Value 
            {
                get
                {
                    return this.value;
                }

                set
                {
                    if (value == null)
                    {
                        throw new ArgumentNullException("Value cannot be null!");
                    }

                    this.value = value;
                }
            }

            public ListItem<U> Next 
            {
                get
                {
                    return this.next;
                }

                set
                {
                    this.next = value;
                }
            }
        }

        private ListItem<T> head;
        private ListItem<T> tail;
        private int count;

        public LinkedList()
        {
            this.head = null;
            this.tail = null;
            this.Count = 0;
        }

        /// <summary>
        /// Returns the number of the list elements. 
        /// </summary>
        /// <exception cref="System.IndexOutOfRangeException">
        /// Invalid value.
        /// </exception>
        public int Count
        {
            get
            {
                return this.count;
            }

            private set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("Count property cannot be negative!");
                }

                this.count = value;
            }
        }

        /// <summary>
        /// Gets or sets the element on the specified position.
        /// </summary>
        /// <param name="index">The position of the element [0 … count-1].</param>
        /// <returns>The item value at the specified index.</</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Index is out of the list range.
        /// </exception>
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException("Index cannot be negative or bigger than list elements!");
                }

                ListItem<T> currentItem = this.head;

                for (int i = 0; i < index; i++)
                {
                    currentItem = currentItem.Next;
                }

                return currentItem.Value;
            }

            set
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException("Index cannot be negative or bigger than list elements!");
                }

                ListItem<T> currentItem = this.head;

                for (int i = 0; i < index; i++)
                {
                    currentItem = currentItem.Next;
                }

                currentItem.Value = value;
            }
        }

        /// <summary>
        /// Add element at the end of the list.
        /// </summary>
        /// <param name="element">The element you want to add.</param>
        /// <exception cref="System.ArgumentNullException">
        /// Invalid element.
        /// </exception>
        public void Add(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("The element you want to add cannot be null!");
            }

            if (this.head == null)
            {
                // If list is empty.
                this.head = new ListItem<T>(element);
                this.tail = this.head;
            }
            else
            {
                // If list is not empty.
                ListItem<T> newItem = new ListItem<T>(element, this.tail);
                this.tail = newItem;
            }

            this.Count++;
        }

        /// <summary>
        /// Inserts given element to the list at a specified position.
        /// </summary>
        /// <param name="index">The index where you want to insert element.</param>
        /// <param name="element">The element you want to insert.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Invalid index.
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Invalid element.
        /// </exception>
        public void Insert(int index, T element)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException("Index cannot be negative or bigger than list elements!");
            }

            if (element == null)
            {
                throw new ArgumentNullException("The element you want to insert cannot be null!");
            }

            if (index == 0)
            {
                // If you want to insert element at the head.
                ListItem<T> newItem = new ListItem<T>(element);
                newItem.Next = this.head;
                this.head = newItem;
            }
            else if (index == this.Count - 1)
            {
                // If you want to insert element at the end.
                ListItem<T> newItem = new ListItem<T>(element);
                this.tail.Next = newItem;
            }
            else
            {
                // Find the item at the specified index.
                ListItem<T> currentItem = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentItem = currentItem.Next;
                }

                // Find previous item.
                ListItem<T> prevItem = this.head;
                for (int i = 0; i < index - 1; i++)
                {
                    prevItem = prevItem.Next;
                }

                ListItem<T> newItem = new ListItem<T>(element, prevItem);
                newItem.Next = currentItem;
            }

            this.Count++;
        }

        /// <summary>
        /// Removes the first occurrence of given element.
        /// </summary>
        /// <param name="element">The element that you want to remove.</param>
        /// <returns>True - if element is removed. False - if there is no such element in the list.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// Invalid element.
        /// </exception>
        public bool Remove(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("The element you want to remove cannot be null!");
            }

            ListItem<T> currentItem = this.head;
            int currentItemIndex = 0;
            bool isListContainsElement = false;

            while (currentItemIndex < this.Count)
            {
                if (element.Equals(currentItem.Value) == true)
                {
                    isListContainsElement = true;
                    break;
                }

                currentItem = currentItem.Next;
                currentItemIndex++;
            }

            if (isListContainsElement == false)
            {
                // If list doesn't contains the given element.
                return false;
            }

            if (currentItemIndex == 0)
            {
                // If the head contains the element.
                this.head = currentItem.Next;
            }
            else
            {
                // Find previous element.
                ListItem<T> prevItem = this.head;

                for (int i = 0; i < this.Count; i++)
                {
                    if (i == currentItemIndex - 1)
                    {
                        break;
                    }

                    prevItem = prevItem.Next;
                }

                if (currentItemIndex == this.Count - 1)
                {
                    // If the element is contained at the end.
                    prevItem.Next = null;
                }
                else
                {
                    // If the element is between others two elements.
                    prevItem.Next = currentItem.Next;
                }
            }

            this.Count--;
            return true;
        }

        /// <summary>
        /// Removes the element at the specified position
        /// </summary>
        /// <param name="index">The index of the element that you want to remove.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Invalid index.
        /// </exception>
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException("Index cannot be negative or bigger than list elements!");
            }

            ListItem<T> currentItem = this.head;

            for (int i = 0; i < this.Count; i++)
            {
                if (i == index)
                {
                    this.Remove(currentItem.Value);
                }

                currentItem = currentItem.Next;
            }
        }

        /// <summary>
        /// Removes all elements from the list.
        /// </summary>
        public void Clear()
        {
            this.head = null;
            this.tail = null;
            this.Count = 0;
        }

        /// <summary>
        /// Determines whether an element is part of the list.
        /// </summary>
        /// <param name="element">The element that you want to check.</param>
        /// <returns>True - if the list contains the given element. False - if not.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// Invalid element.
        /// </exception>
        public bool Contains(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("The element you want to check cannot be null!");
            }

            ListItem<T> currentItem = this.head;

            for (int i = 0; i < this.Count; i++)
            {
                if (element.Equals(currentItem.Value) == true)
                {
                    return true;
                }

                currentItem = currentItem.Next;
            }

            return false;
        }

        /// <summary>
        /// Returns the index of the first occurrence of a value in the list (zero-based).
        /// </summary>
        /// <param name="element">The element wich index you want to find.</param>
        /// <returns>Index of the element, otherwise returns -1 if there is no such element in the list.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// Invalid element.
        /// </exception>
        public int IndexOf(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("The element you check to add cannot be null!");
            }

            ListItem<T> currentItem = this.head;

            for (int index = 0; index < this.Count; index++)
            {
                if (element.Equals(currentItem.Value) == true)
                {
                    return index;
                }

                currentItem = currentItem.Next;
            }

            return -1;
        }

        /// <summary>
        /// Convert list to array.
        /// </summary>
        /// <returns>Array with elements from the list.</returns>
        public T[] ToArray()
        {
            T[] array = new T[this.Count];
            ListItem<T> currentItem = this.head;

            for (int i = 0; i < this.Count; i++)
            {
                array[i] = currentItem.Value;
                currentItem = currentItem.Next;
            }

            return array;
        }

        /// <summary>
        /// Reverses the order of the elements in the list.
        /// </summary>
        public void Reverse()
        {
            T[] array = new T[this.Count];
            ListItem<T> currentItem = this.head;

            for (int i = this.Count - 1; i >= 0; i--)
            {
                array[i] = currentItem.Value;
                currentItem = currentItem.Next;
            }

            this.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                this.Add(array[i]);
            }
        }

        /// <summary>
        /// Sorts list elements in ascending order.
        /// </summary>
        public void Sort()
        {
            T[] array = new T[this.Count];
            ListItem<T> currentItem = this.head;

            for (int i = this.Count - 1; i >= 0; i--)
            {
                array[i] = currentItem.Value;
                currentItem = currentItem.Next;
            }

            Array.Sort(array);
            this.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                this.Add(array[i]);
            }
        }

        /// <summary>
        /// Prints list elements.
        /// </summary>
        /// <example>
        /// LinkedList<int> linkedList = new LinkedList<int>();
        /// linkedList.Add(1);
        /// Console.WriteLine(linkedList);
        /// // Output: 1
        /// </example>
        /// <returns>List elements as a string.</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            T[] array = this.ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    builder.Append(array[i]);
                }
                else
                {
                    builder.Append(array[i] + " ");
                }
            }

            return builder.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var item = this.head; item != null; item = item.Next)
            {
                yield return item.Value;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
