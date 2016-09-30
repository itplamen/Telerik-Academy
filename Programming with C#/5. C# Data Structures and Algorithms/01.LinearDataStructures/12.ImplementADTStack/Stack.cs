namespace _12.ImplementADTStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Stack<T> : IEnumerable<T>
    {
        private const int INITIAL_ARRAY_CAPACITY = 4;
        private T[] array;
        private int count;

        public Stack(uint capacity)
        {
            this.array = new T[capacity];
            this.Count = 0; 
        }

        public Stack()
            : this(INITIAL_ARRAY_CAPACITY)
        {  
        }

        /// <summary>
        /// Returns capacity of the stack;
        /// </summary>
        public int Capacity 
        {
            get
            {
                return this.array.Length;
            } 
        }

        /// <summary>
        /// Returns number of the stack elements.
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
                if (value < 0 || value > this.array.Length)
                {
                    throw new IndexOutOfRangeException("Count property cannot be negative or bigger than array size!");
                }

                this.count = value;
            }
        }

        /// <summary>
        /// Add elements at the top of the stack.
        /// </summary>
        /// <param name="element">The element you want to add.</param>
        /// <exception cref="System.ArgumentNullException">
        /// Invaid element.
        /// </exception>
        public void Push(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Cannot push null element!");
            }

            if (this.Count == 0 && this.Capacity == 0)
            {
                // If the stack is empty.
                this.array = new T[INITIAL_ARRAY_CAPACITY];
            }
            else if ((this.Count != 0 && this.Capacity != 0) && (this.Count == this.Capacity))
            {
                this.ExtendArray();
            }

            this.array[this.Count] = element;
            this.Count++;
        }

        /// <summary>
        /// Removes and returns the top element from the stack.
        /// </summary>
        /// <returns>Top element from the stack.</returns>
        /// <exception cref="System.InvalidOperationException">
        /// Empty stack.
        /// </exception>
        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            
            int topElementIndex = this.Count - 1;
            T topElement = this.array[topElementIndex];
            T[] temporaryArray = new T[this.Count - 1];
            Array.Copy(this.array, temporaryArray, this.Count - 1);
            this.array = temporaryArray;
            this.Count--;
            return topElement;
        }

        /// <summary>
        /// Returns the top element from the stack without removing it.
        /// </summary>
        /// <returns>Top element from the stack.</returns>
        /// <exception cref="System.InvalidOperationException">
        /// Empty stack.
        /// </exception>
        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            return this.array[this.Count - 1];
        }

        /// <summary>
        /// Removes all elements from the stack;
        /// </summary>
        public void Clear()
        {
            this.array = new T[INITIAL_ARRAY_CAPACITY];
            this.Count = 0;
        }

        /// <summary>
        /// Determines whether given element is in the stack.
        /// </summary>
        /// <param name="element">The element that you want to check.</param>
        /// <returns>True - if the stack contains the given element. False - if not.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// Invaid element.
        /// </exception>
        public bool Contains(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Cannot check null element!");
            }

            for (int i = 0; i < this.Count; i++)
            {
                if (element.Equals(this.array[i]) == true)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Converts the stack to an array.
        /// </summary>
        /// <returns>Array with all elements from the stack.</returns>
        public T[] ToArray()
        {
            T[] returnedArray = new T[this.Count];
            Array.Copy(this.array, returnedArray, this.Count);
            return returnedArray;
        }
        
        /// <summary>
        /// Sets the capacity to the actual number of elements.
        /// </summary>
        public void TrimExcess()
        {
            T[] temporaryArray = new T[this.Count];
            Array.Copy(this.array, temporaryArray, this.Count);
            this.array = temporaryArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return this.array[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        // Extends array if its necessary
        private void ExtendArray()
        {
            T[] extendedArray = new T[this.Capacity * 2];
            Array.Copy(this.array, extendedArray, this.Capacity);
            this.array = extendedArray;
        }
    }
}
