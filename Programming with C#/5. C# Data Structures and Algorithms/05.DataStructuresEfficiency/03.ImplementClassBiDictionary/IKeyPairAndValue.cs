namespace _03.ImplementClassBiDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IKeyPairAndValue<TKey1, TKey2, TValue> : IEquatable<IKeyPairAndValue<TKey1, TKey2, TValue>>
    {
        TKey1 Key1 { get; }

        TKey2 Key2 { get; }

        TValue Value { get; }

        bool Equals(IKeyPairAndValue<TKey1, TKey2, TValue> other);

        bool Equals(object obj);

        int GetHashCode();
    }
}
