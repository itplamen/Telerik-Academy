namespace _03.ImplementClassBiDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IBiDictionary<TKey1, TKey2, TValue>
    {
        int Count { get; }

        ICollection<TValue> CollectionOfValues { get; }

        ICollection<Tuple<TKey1, TKey2>> CollectionOfKeys { get; }

        void Add(TKey1 key1, TKey2 key2, TValue value);

        ICollection<TValue> FindBy(TKey1 key1);

        ICollection<TValue> FindBy(TKey2 key2);

        ICollection<TValue> FindBy(TKey1 key1, TKey2 key2);

        bool ContainsKey(TKey1 key1);

        bool ContainsKey(TKey2 key2);

        bool Contains(TKey1 key1, TKey2 key2, TValue value);

        bool Remove(TKey1 key1);

        bool Remove(TKey2 key2);

        bool Remove(TKey1 key1, TKey2 key2);

        void Clear();

        string ToString();
    }
}
