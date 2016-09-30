namespace _03.ImplementClassBiDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wintellect.PowerCollections;

    public class BiDictionary<TKey1, TKey2, TValue> : IBiDictionary<TKey1, TKey2, TValue>
    {
        private class KeyPairAndValue : IKeyPairAndValue<TKey1, TKey2, TValue> 
        {
            private TKey1 key1;
            private TKey2 key2;
            private TValue value;

            public KeyPairAndValue(TKey1 key1, TKey2 key2, TValue value)
            {
                this.Key1 = key1;
                this.Key2 = key2;
                this.Value = value;
            }

            public TKey1 Key1 
            {
                get
                {
                    return this.key1;
                }

                private set
                {
                    if (value == null)
                    {
                        throw new ArgumentNullException("Key1 cannot be null!");
                    }

                    this.key1 = value;
                } 
            }

            public TKey2 Key2
            {
                get
                {
                    return this.key2;
                }

                private set
                {
                    if (value == null)
                    {
                        throw new ArgumentNullException("Key2 cannot be null!");
                    }

                    this.key2 = value;
                }
            }

            public TValue Value
            {
                get
                {
                    return this.value;
                }

                private set
                {
                    if (value == null)
                    {
                        throw new ArgumentNullException("Value cannot be null!");
                    }

                    this.value = value;
                }
            }

            public bool Equals(IKeyPairAndValue<TKey1, TKey2, TValue> other)
            {
                return !ReferenceEquals(other, null) &&
                       this.Key1.Equals(other.Key1) &&
                       this.Key2.Equals(other.Key2) &&
                       this.Value.Equals(other.Value);
            }

            public override bool Equals(object obj)
            {
                return this.Equals(obj as IKeyPairAndValue<TKey1, TKey2, TValue>);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    int hashCode = 0;

                    hashCode = (hashCode * 17) ^ this.Key1.GetHashCode();
                    hashCode = (hashCode * 17) ^ this.Key2.GetHashCode();
                    hashCode = (hashCode * 17) ^ this.Value.GetHashCode();

                    return hashCode;
                }
            }
        }

        private MultiDictionary<TKey1, KeyPairAndValue> byKey1;
        private MultiDictionary<TKey2, KeyPairAndValue> byKey2;
        private MultiDictionary<Tuple<TKey1, TKey2>, KeyPairAndValue> byKey1Key2;

        public BiDictionary(bool allowDuplicateValues)
        {
            this.byKey1 = new MultiDictionary<TKey1, KeyPairAndValue>(allowDuplicateValues);
            this.byKey2 = new MultiDictionary<TKey2, KeyPairAndValue>(allowDuplicateValues);
            this.byKey1Key2 = new MultiDictionary<Tuple<TKey1, TKey2>, KeyPairAndValue>(allowDuplicateValues);
        }

        public int Count
        {
            get
            {
                Debug.Assert(this.byKey1.Count == this.byKey2.Count && this.byKey1.Count == this.byKey1Key2.Count, "Different number of elements!");
                return this.byKey1.Count;
            }
        }

        public ICollection<TValue> CollectionOfValues 
        {
            get
            {
                return this.byKey1Key2.Values.Select(value => value.Value).ToArray();
            } 
        }

        public ICollection<Tuple<TKey1, TKey2>> CollectionOfKeys 
        {
            get
            {
                return this.byKey1Key2.Keys.Select(key => new Tuple<TKey1, TKey2>(key.Item1, key.Item2)).ToArray();
            } 
        }

        public void Add(TKey1 key1, TKey2 key2, TValue value)
        {
            this.byKey1.Add(key1, new KeyPairAndValue(key1, key2, value));
            this.byKey2.Add(key2, new KeyPairAndValue(key1, key2, value));
            this.byKey1Key2.Add(new Tuple<TKey1, TKey2>(key1, key2), new KeyPairAndValue(key1, key2, value));
        }

        public ICollection<TValue> FindBy(TKey1 key1)
        {
            return this.byKey1[key1].Select(item => item.Value).ToArray();
        }

        public ICollection<TValue> FindBy(TKey2 key2)
        {
            return this.byKey2[key2].Select(item => item.Value).ToArray();
        }

        public ICollection<TValue> FindBy(TKey1 key1, TKey2 key2)
        {
            return this.byKey1Key2[new Tuple<TKey1, TKey2>(key1, key2)].Select(item => item.Value).ToArray();
        }

        public bool ContainsKey(TKey1 key1)
        {
            return this.byKey1.ContainsKey(key1);
        }

        public bool ContainsKey(TKey2 key2)
        {
            return this.byKey2.ContainsKey(key2);
        }

        public bool Contains(TKey1 key1, TKey2 key2, TValue value)
        {
            return this.byKey1Key2.Contains(new Tuple<TKey1, TKey2>(key1, key2), new KeyPairAndValue(key1, key2, value));
        }

        public bool Remove(TKey1 key1)
        {
            foreach (var item in this.byKey1[key1])
            {
                this.byKey2.Remove(item.Key2);
                this.byKey1Key2.Remove(new Tuple<TKey1, TKey2>(item.Key1, item.Key2));
            }

            return this.byKey1.Remove(key1);
        }

        public bool Remove(TKey2 key2)
        {
            foreach (var item in this.byKey2[key2])
            {
                this.byKey1.Remove(item.Key1);
                this.byKey1Key2.Remove(new Tuple<TKey1, TKey2>(item.Key1, item.Key2));
            }

            return this.byKey2.Remove(key2);
        }

        public bool Remove(TKey1 key1, TKey2 key2)
        {
            foreach (var item in this.byKey1Key2[new Tuple<TKey1, TKey2>(key1, key2)])
            {
                this.byKey1.Remove(item.Key1);
                this.byKey2.Remove(item.Key2);
            }

            return this.byKey1Key2.Remove(new Tuple<TKey1, TKey2>(key1, key2));
        }

        public void Clear()
        {
            this.byKey1.Clear();
            this.byKey2.Clear();
            this.byKey1Key2.Clear();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var item in this.byKey1Key2)
            {
                builder.Append("{" + item.Key.Item1 + ", " + item.Key.Item2 + ", ");

                foreach (var value in item.Value)
                {
                    builder.AppendLine(value.Value.ToString() + "}");
                }
            }

            return builder.ToString();
        }
    }
}
