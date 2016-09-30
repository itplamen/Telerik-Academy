namespace _04.ImplementDataStructureHashTable.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HashTableTests
    {
        private HashTable<string, int> hashTable;

        [TestInitialize]
        public void TestInitialize()
        {
            this.hashTable = new HashTable<string, int>();
        }

        [TestMethod]
        public void Indexer_ReturnValue()
        {
            this.hashTable.Add("ruby", 133);
            this.hashTable.Add("ajax", 15);
            var expected = 15;
            Assert.AreEqual(expected, this.hashTable["ajax"]);
        }

        [TestMethod]
        public void Indexer_AddKeyAndValueWhenKeyDoesntExist()
        {
            this.hashTable.Add("ruby", 133);
            this.hashTable.Add("ajax", 15);
            this.hashTable["Google"] = 22;
            Assert.IsTrue(this.hashTable.ContainsKey("Google"));
        }

        [TestMethod]
        public void Indexer_OverwriteValueIfKeyExist()
        {
            this.hashTable.Add("ruby", 133);
            this.hashTable.Add("ajax", 15);
            this.hashTable["ajax"] = -16;
            var expected = -16;
            Assert.AreEqual(expected, this.hashTable["ajax"]);
        }

        [TestMethod]
        public void Keys_ReturAllKeyFromTheHashTable()
        {
            this.hashTable.Add("ruby", 133);
            this.hashTable.Add("ajax", 15);

            var expectedKeys = new List<string>() { "ruby", "ajax" };
            expectedKeys.Sort();
            var expected = true;

            var resultKeys = this.hashTable.Keys;
            resultKeys.Sort();

            for (int i = 0; i < resultKeys.Count; i++)
            {
                if ((resultKeys[i] != expectedKeys[i]) || (resultKeys.Count != expectedKeys.Count))
                {
                    expected = false;
                    break;
                }
            }

            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void Values_ReturAllKeyFromTheHashTable()
        {
            this.hashTable.Add("ruby", 133);
            this.hashTable.Add("ajax", 15);

            var expectedKeys = new List<int>() { 133, 15 };
            expectedKeys.Sort();
            var expected = true;

            var resultKeys = this.hashTable.Values;
            resultKeys.Sort();

            for (int i = 0; i < resultKeys.Count; i++)
            {
                if ((resultKeys[i] != expectedKeys[i]) || (resultKeys.Count != expectedKeys.Count))
                {
                    expected = false;
                    break;
                }
            }

            Assert.IsTrue(expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Add_KeyAlreadyExist()
        {
            this.hashTable.Add("pascal", 0);
            this.hashTable.Add("c", 3);
            this.hashTable.Add("pascal", 66);
        }

        [TestMethod]
        public void Add_ExtendHashTableWhenReach75PercentOfCapacity()
        {
            const double REACH_CAPACITY = 0.75;
            var newHashTable = new HashTable<int, int>();
            int expectedCapacity = newHashTable.Capacity * 2;
            int numberOfElements = (int)(newHashTable.Capacity * REACH_CAPACITY) + 1;

            for (int i = 1; i <= numberOfElements; i++)
            {
                newHashTable.Add(i, i * 10);
            }

            Assert.AreEqual(expectedCapacity, newHashTable.Capacity);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Find_KeyDoesntExist()
        {
            this.hashTable.Add("SQL", -18);
            this.hashTable.Add("MySql", 1);
            this.hashTable.Add("php", 15);
            this.hashTable.Add("clr", 100);
            this.hashTable.Add("cts", 13);

            this.hashTable.Find("ASP.NET");
        }

        [TestMethod]
        public void Find_ExistKey()
        {
            this.hashTable.Add("SQL", -18);
            this.hashTable.Add("MySql", 1);
            this.hashTable.Add("php", 15);
            this.hashTable.Add("clr", 100);
            this.hashTable.Add("cts", 13);

            var expected = 15;
            Assert.AreEqual(expected, this.hashTable.Find("php"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Remove_KeyDoesntExist()
        {
            this.hashTable.Add("SQL", -18);
            this.hashTable.Add("MySql", 1);
            this.hashTable.Add("php", 15);
            this.hashTable.Add("clr", 100);
            this.hashTable.Add("cts", 13);

            this.hashTable.Remove("mono");
        }

        [TestMethod]
        public void Remove_RemoveKeyAndValue()
        {
            this.hashTable.Add("SQL", -18);
            this.hashTable.Add("MySql", 1);
            this.hashTable.Add("php", 15);
            this.hashTable.Add("clr", 100);
            this.hashTable.Add("cts", 13);

            Assert.IsTrue(this.hashTable.Remove("php"));
        }

        [TestMethod]
        public void ContainsKey_True()
        {
            this.hashTable.Add("SQL", 11);
            Assert.IsTrue(this.hashTable.ContainsKey("SQL"));
        }

        [TestMethod]
        public void ContainsKey_False()
        {
            this.hashTable.Add("SQL", 11);
            Assert.IsFalse(this.hashTable.ContainsKey("C#"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ContainsKey_NullKey()
        {
            this.hashTable.Add("SQL", 11);
            this.hashTable.ContainsKey(null);
        }

        [TestMethod]
        public void ContainsValue_True()
        {
            this.hashTable.Add("SQL", 11);
            Assert.IsTrue(this.hashTable.ContainsValue(11));
        }

        [TestMethod]
        public void ContainsValue_False()
        {
            this.hashTable.Add("SQL", 11);
            Assert.IsFalse(this.hashTable.ContainsValue(2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ContainsValue_NullValue()
        {
            HashTable<int, string> newHashTable = new HashTable<int, string>();
            newHashTable.Add(-66, ".Net");
            newHashTable.ContainsValue(null);
        }

        [TestMethod]
        public void Clear_RemoveAllKeysAndValues()
        {
            List<string> keys = new List<string>()
            {
                "java", "JavaScript", "HTML", "CSS", "mono", "ado.net", ".net", "cts", "clr", "C#", 
                "c", "c++", "IL", 
            };

            List<int> values = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int initialCapacity = this.hashTable.Capacity;
            int numberOfElements = 13;

            for (int i = 0; i < numberOfElements; i++)
            {
                this.hashTable.Add(keys[i], values[i]);
            }

            this.hashTable.Clear();
            bool isHashTableEmpty = true;

            for (int i = 0; i < numberOfElements; i++)
            {
                if (this.hashTable.ContainsKey(keys[i]) == true || 
                    this.hashTable.ContainsValue(values[i]) == true ||
                    this.hashTable.Count != 0 || this.hashTable.Capacity != initialCapacity)
                {
                    isHashTableEmpty = false;
                    break;
                }
            }

            Assert.IsTrue(isHashTableEmpty);
        }

        [TestMethod]
        public void GetEnumeratorTest()
        {
            this.hashTable.Add("SQL", -18);
            this.hashTable.Add("MySql", 1);
            this.hashTable.Add("php", 15);
            this.hashTable.Add("clr", 100);
            this.hashTable.Add("cts", 13);

            StringBuilder builder = new StringBuilder();

            foreach (var pair in this.hashTable)
            {
                builder.AppendLine(" " + pair.Key + " -> " + " ," + pair.Value);
            }
        }
    }
}
