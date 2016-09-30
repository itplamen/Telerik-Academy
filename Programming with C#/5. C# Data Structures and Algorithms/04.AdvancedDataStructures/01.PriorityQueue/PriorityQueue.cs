namespace _01.PriorityQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PriorityQueue<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        private List<T> binaryHeap;

        public PriorityQueue()
        {
            this.binaryHeap = new List<T>();
        }

        /// <summary>
        /// Returns the number of the elements. 
        /// </summary>
        public int Count 
        {
            get
            {
                return this.binaryHeap.Count;
            }
        }

        /// <summary>
        /// Add element.
        /// </summary>
        /// <param name="element">The element you want to add.</param>
        /// <exception cref="System.ArgumentNullException">
        /// Invalid element.
        /// </exception>
        public void Enqueue(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Cannot enqueue null element!");
            }

            this.binaryHeap.Add(element);

            if (this.Count != 1)
            {
                int elementIndex = this.Count - 1;
                while (true)
                {
                    int parrentIndex = (elementIndex - 1) / 2;

                    if (element.CompareTo(this.binaryHeap[parrentIndex]) < 0)
                    {
                        elementIndex = this.Swap(elementIndex, parrentIndex);
                    }
                    else
                    {
                        break;
                    }
                }
            } 
        }

        /// <summary>
        /// Removes and returns the element with the highest priority.
        /// </summary>
        /// <returns>The element with the highest priority.</returns>
        /// <exception cref="System.InvalidOperationException">
        /// Empty priority queue.
        /// </exception>
        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The priority queue is empty!");
            }

            T root = this.binaryHeap[0];
            this.binaryHeap[0] = this.binaryHeap[this.Count - 1];
            this.binaryHeap.RemoveAt(this.Count - 1);
            
            if (this.Count > 1)
            {
                this.MinHeapify(this.binaryHeap[0], 0);
            }

            return root;
        }

        /// <summary>
        /// Returns the element at the beginning with the highest priority without removing it.
        /// </summary>
        /// <returns>The element with highest priority.</returns>
        /// <exception cref="System.InvalidOperationException">
        /// Empty priority queue.
        /// </exception
        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The priority queue is empty!");
            }

            return this.binaryHeap[0];
        }

        /// <summary>
        /// Removes all elements.
        /// </summary>
        public void Clear()
        {
            this.binaryHeap.Clear();
        }

        /// <summary>
        /// Determines whether given element is in the priority queue.
        /// </summary>
        /// <param name="element">The element that you want to check.</param>
        /// <returns>True - if the priority queue contains the given element. False - if not.</returns>
        /// <exception cref="System.InvalidOperationException">
        /// Empty priority queue.
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Invalid element.
        /// </exception>
        public bool Contains(T element)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The priority queue is empty!");
            }

            if (element == null)
            {
                throw new ArgumentNullException("Cannot check nullable element!");
            }

            return this.binaryHeap.Contains(element);
        }

        /// <summary>
        /// Converts the priority queue to array.
        /// </summary>
        /// <returns>Array with the elements from priority queue.</returns>
        public T[] ToArray()
        {
            return this.binaryHeap.ToArray();
        }

        /// <summary>
        /// Prints priority queue elements.
        /// </summary>
        /// <returns>Elements as a string.</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < this.Count; i++)
            {
                if (i == this.Count - 1)
                {
                    builder.Append(this.binaryHeap[i]);
                }
                else
                {
                    builder.Append(this.binaryHeap[i] + ", ");
                }
            }

            return builder.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.binaryHeap)
            {
                yield return item;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void MinHeapify(T currentElement, int currentIndex)
        {
            while (true)
            {
                int minElementIndex = currentIndex;
                int leftChildIdndex = (2 * currentIndex) + 1;
                int rightChildIndex = leftChildIdndex + 1;

                if (leftChildIdndex < this.Count && this.binaryHeap[leftChildIdndex].CompareTo(this.binaryHeap[currentIndex]) < 0)
                {
                    currentIndex = leftChildIdndex;
                }

                if (rightChildIndex < this.Count && this.binaryHeap[rightChildIndex].CompareTo(this.binaryHeap[currentIndex]) < 0)
                {
                    currentIndex = rightChildIndex;
                }

                currentElement = this.binaryHeap[currentIndex];

                if (currentElement.CompareTo(this.binaryHeap[minElementIndex]) < 0)
                {
                    this.Swap(currentIndex, minElementIndex);
                }
                else
                {
                    break;
                }
            }
        }

        private int Swap(int childIndex, int parrentIndex)
        {
            T currentElement = this.binaryHeap[parrentIndex];
            this.binaryHeap[parrentIndex] = this.binaryHeap[childIndex];
            this.binaryHeap[childIndex] = currentElement;
            return parrentIndex;
        }       
    }
}
