namespace _13.ImplementADTQueueAsDynamicLinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LinkedQueue<T> : IEnumerable<T>
    {
        private class QueueItem<U>
        {
            private U value;
            private QueueItem<U> next;

            public QueueItem(U value)
            {
                this.Value = value;
                this.Next = null;
            }

            public QueueItem(U value, QueueItem<U> prev)
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

            public QueueItem<U> Next 
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

        private QueueItem<T> head;
        private QueueItem<T> tail;
        private int count;

        public LinkedQueue()
        {
            this.head = null;
            this.tail = null;
            this.Count = 0;
        }

        /// <summary>
        /// Returns the number of the queue elements. 
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
        /// Add element at the end of the queue.
        /// </summary>
        /// <param name="element">The element you want to add.</param>
        /// <exception cref="System.ArgumentNullException">
        /// Invalid element.
        /// </exception>
        public void Enqueue(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Cannot enqueue nullable element!");
            }

            if (this.head == null)
            {
                // If queue is empty.
                this.head = new QueueItem<T>(element);
                this.tail = this.head;
            }
            else
            {
                // If queue is not empty.
                QueueItem<T> newItem = new QueueItem<T>(element, this.tail);
                this.tail = newItem;
            }

            this.Count++;
        }

        /// <summary>
        /// Removes and returns the element at the beginning of the queue.
        /// </summary>
        /// <returns>The first element from the queue.</returns>
        /// <exception cref="System.InvalidOperationException">
        /// Empty queue.
        /// </exception>
        public T Dequeue()
        {
            if (this.head == null)
            {
                throw new InvalidOperationException("The queue is empty!");
            }

            QueueItem<T> firstItem = this.head;
            this.head = this.head.Next;
            this.Count--;
            return firstItem.Value;
        }

        /// <summary>
        /// Returns the element at the beginning of the queue without removing it.
        /// </summary>
        /// <returns>The first element from the queue.</returns>
        /// <exception cref="System.InvalidOperationException">
        /// Empty queue.
        /// </exception>
        public T Peek()
        {
            if (this.head == null)
            {
                throw new InvalidOperationException("The queue is empty!");
            }

            return this.head.Value;
        }

        /// <summary>
        /// Removes all elements from the queue.
        /// </summary>
        public void Clear()
        {
            this.head = null;
            this.tail = null;
            this.Count = 0;
        }

        /// <summary>
        /// Determines whether given element is in the queue.
        /// </summary>
        /// <param name="element">The element that you want to check.</param>
        /// <returns>True - if the queue contains the given element. False - if not.</returns>
        /// <exception cref="System.InvalidOperationException">
        /// Empty queue.
        /// </exception>
        public bool Contains(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Cannot check nullable element!");
            }

            QueueItem<T> currentItem = this.head;

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
        /// Convert queue to array.
        /// </summary>
        /// <returns>Array with elements from the queue.</returns>
        public T[] ToArray()
        {
            T[] array = new T[this.Count];
            QueueItem<T> currentItem = this.head;

            for (int i = 0; i < this.Count; i++)
            {
                array[i] = currentItem.Value;
                currentItem = currentItem.Next;
            }

            return array;
        }

        /// <summary>
        /// Prints queue elements.
        /// </summary>
        /// <example>
        /// LinkedQueue<int> linkedQueue = new LinkedQueue<int>();
        /// linkedQueue.Enqueue(1);
        /// Console.WriteLine(linkedQueue);
        /// // Output: 1
        /// </example>
        /// <returns>Queue elements as a string.</returns>
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
