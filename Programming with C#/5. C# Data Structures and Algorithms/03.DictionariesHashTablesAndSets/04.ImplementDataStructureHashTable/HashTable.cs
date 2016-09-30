namespace _04.ImplementDataStructureHashTable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HashTable<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        private const int INITIAL_CAPACITY = 16;
        private const double REACH_CAPACITY = 0.75;
        private int count;
        private LinkedList<KeyValuePair<TKey, TValue>>[] hashTable;

        public HashTable()
            : this(INITIAL_CAPACITY)
        {
        }

        public HashTable(uint capacity)
        {
            this.hashTable = new LinkedList<KeyValuePair<TKey, TValue>>[capacity];
            this.Count = 0;
        }

        /// <summary>
        /// Returns the capacity of the hash table.
        /// </summary>
        public int Capacity 
        {
            get
            {
                return this.hashTable.Length;
            } 
        }

        /// <summary>
        /// Returns the number ot the elements in the hash table.
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
                if (value < 0 || value > this.Capacity)
                {
                    throw new IndexOutOfRangeException("Count property cannot be negative or bigger than hash table length!");
                }

                this.count = value;
            }
        }

        /// <summary>
        /// Indexer for get / add / replace of element by key.
        /// </summary>
        /// <param name="key">
        /// The key wich value you want to get / replace or to add new element with specified key and value.
        /// </param>
        /// <returns>Key's value.</returns>
        public TValue this[TKey key]
        {
            get
            {
                return this.Find(key);
            }

            set
            {
                if (this.ContainsKey(key) == false)
                {
                    // Add key and value to the hash table if key doesnt exist.
                    this.Add(key, value);
                }
                else
                {
                    // Overwrite value if key exist.
                    var index = this.CalculateHashCode(key);
                    LinkedList<KeyValuePair<TKey, TValue>> newLinkedList = new LinkedList<KeyValuePair<TKey, TValue>>();

                    foreach (var pair in this.hashTable[index])
                    {
                        if (pair.Key.Equals(key) == true)
                        {
                            // Add the new key and value.
                            newLinkedList.AddLast(new KeyValuePair<TKey, TValue>(key, value));
                        }
                        else
                        {
                            newLinkedList.AddLast(new KeyValuePair<TKey, TValue>(pair.Key, pair.Value));
                        }
                    }

                    this.hashTable[index] = newLinkedList;
                }
            }
        }

        /// <summary>
        /// Returns a collection of the keys.
        /// </summary>
        public List<TKey> Keys 
        {
            get
            {
                List<TKey> keys = new List<TKey>();

                foreach (var linkedList in this.hashTable)
                {
                    if (linkedList != null)
                    {
                        foreach (var pair in linkedList)
                        {
                            keys.Add(pair.Key);
                        }
                    }
                }

                return keys;
            } 
        }

        /// <summary>
        /// Returns a collection of the values.
        /// </summary>
        public List<TValue> Values
        {
            get
            {
                List<TValue> values = new List<TValue>();

                foreach (var linkedList in this.hashTable)
                {
                    if (linkedList != null)
                    {
                        foreach (var pair in linkedList)
                        {
                            values.Add(pair.Value);
                        }
                    }
                }

                return values;
            }
        }

        /// <summary>
        /// Adds an element with the specified key and value.
        /// </summary>
        /// <param name="key">The key you want to add.</param>
        /// <param name="value">The value you want to add.</param>
        /// <exception cref="System.ArgumentException">
        /// When the key already has been added.
        /// </exception>
        public void Add(TKey key, TValue value)
        {
            if (this.ContainsKey(key) == true)
            {
                throw new ArgumentException("Key already exist!");
            }

            // Extend hash table.
            if (this.Count == this.Capacity * REACH_CAPACITY)
            {
                this.ExtendHashTable();
            }
            
            var index = this.CalculateHashCode(key);

            if (this.hashTable[index] == null)
            {
                this.hashTable[index] = new LinkedList<KeyValuePair<TKey, TValue>>(); 
            }

            KeyValuePair<TKey, TValue> pair = new KeyValuePair<TKey, TValue>(key, value);
            this.hashTable[index].AddLast(new LinkedListNode<KeyValuePair<TKey, TValue>>(pair));
            this.Count++;
        }

        /// <summary>
        /// Find specified key and value.
        /// </summary>
        /// <param name="key">The key you want to find.</param>
        /// <returns>The value of the specified key.</returns>
        /// <exception cref="System.ArgumentException">
        /// Invalid key.
        /// </exception>
        public TValue Find(TKey key)
        {
            if (this.ContainsKey(key) == false)
            {
                throw new ArgumentException("There is no such key in the hash table!");
            }

            var index = this.CalculateHashCode(key);
            var pair = this.hashTable[index].Single(item => item.Key.Equals(key) == true);
            return pair.Value;
        }

        /// <summary>
        /// Remove the element by key.
        /// </summary>
        /// <param name="key">The key you want to remove.</param>
        /// <returns>True - if key and value are removed. False - if not.</returns>
        /// /// <exception cref="System.ArgumentException">
        /// Invalid key.
        /// </exception>
        public bool Remove(TKey key)
        {
            if (this.ContainsKey(key) == false)
            {
                throw new ArgumentException("There is no such key in the hash table!");
            }

            var index = this.CalculateHashCode(key);

            foreach (var pair in this.hashTable[index])
            {
                if (pair.Key.Equals(key) == true)
                {
                    this.hashTable[index].Remove(pair);
                    this.Count--;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Checks whether the hash table contains given key.
        /// </summary>
        /// <param name="key">The key you want to check.</param>
        /// <returns>True - if the hash table contais the given key. False - if not.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// Invalid key.
        /// </exception>
        public bool ContainsKey(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException("Key cannot be null!");
            }

            var index = this.CalculateHashCode(key);

            if (this.hashTable[index] == null)
            {
                return false;
            }

            return this.hashTable[index].Any(item => item.Key.Equals(key));
        }

        /// <summary>
        /// Checks whether the hash table contains given value.
        /// </summary>
        /// <param name="value">The value you want to check.</param>
        /// <returns>True - if the hash table contais the given value. False - if not.</returns>
        /// /// <exception cref="System.ArgumentNullException">
        /// Invalid key.
        /// </exception>
        public bool ContainsValue(TValue value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Value cannot be null!");
            }

            foreach (var linkedList in this.hashTable)
            {
                if (linkedList != null)
                {
                    foreach (var pair in linkedList)
                    {
                        if (pair.Value.Equals(value) == true)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Removes all elements.
        /// </summary>
        public void Clear()
        {
            this.hashTable = new LinkedList<KeyValuePair<TKey, TValue>>[INITIAL_CAPACITY];
            this.Count = 0;
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            foreach (var linkedList in this.hashTable)
            {
                if (linkedList != null)
                {
                    foreach (var pair in linkedList)
                    {
                        yield return pair;
                    }
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private int CalculateHashCode(TKey key)
        {
            var hashCode = Math.Abs(key.GetHashCode()) % this.hashTable.Length;
            return hashCode;
        }

        private void ExtendHashTable()
        {
            var newHashTable = this.hashTable;
            this.hashTable = new LinkedList<KeyValuePair<TKey, TValue>>[this.Capacity * 2];
            this.Count = 0;

            foreach (var pair in newHashTable)
            {
                if (pair != null)
                {
                    foreach (var item in pair)
                    {
                        this.Add(item.Key, item.Value);
                    }
                }
            }
        }
    }
}
