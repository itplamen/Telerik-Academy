namespace _03.ImplementClassBiDictionary.Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BiDictionaryTests
    {
        private IBiDictionary<string, int, string> biDictionary;
        private IList<Tuple<string, int, string>> list;

        [TestInitialize]
        public void TestInitialize()
        {
            this.biDictionary = new BiDictionary<string, int, string>(true);
            
            this.list = new List<Tuple<string, int, string>>() 
            {
                new Tuple<string, int, string>("Ivan", 21, "C#"),
                new Tuple<string, int, string>("Ivan", 30, "Java"),
                new Tuple<string, int, string>("Misho", 30, "JavaScript"),
                new Tuple<string, int, string>("Iva", 18, "XML"),
                new Tuple<string, int, string>("Nakov", 33, "XAML"),
                new Tuple<string, int, string>("Niki", 24, "WPF")
            };

            for (int i = 0; i < this.list.Count; i++)
            {
                this.biDictionary.Add(this.list[i].Item1, this.list[i].Item2, this.list[i].Item3);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Add_AddNullableKey1()
        {
            this.biDictionary.Add(null, 2, "JDK");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Add_AddNullableKey2()
        {
            IBiDictionary<int, string, int> newBiDictionary = new BiDictionary<int, string, int>(true);
            newBiDictionary.Add(1, null, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Add_AddNullableValue()
        {
            this.biDictionary.Add("JVM", 21, null);
        }

        [TestMethod]
        public void Add_AddCorrectElements()
        {
            bool areElementsAdded = true;

            for (int i = 0; i < this.list.Count; i++)
            {
                if (!this.biDictionary.Contains(this.list[i].Item1, this.list[i].Item2, this.list[i].Item3))
                {
                    areElementsAdded = false;
                    break;
                }
            }

            Assert.IsTrue(areElementsAdded);
        }

        [TestMethod]
        public void FindBy_Key1_ExistingKeys()
        {
            ICollection<string> collectionOfValues = this.biDictionary.FindBy("Ivan");
            bool areValuesFind = true;

            if (collectionOfValues.Count == 2)
            {
                if (!collectionOfValues.Contains("C#") || !collectionOfValues.Contains("Java"))
                {
                    areValuesFind = false;
                }
            }

            Assert.IsTrue(areValuesFind);
        }

        [TestMethod]
        public void FindBy_Key1_NonexistentKey()
        {
            ICollection<string> collectionOfValues = this.biDictionary.FindBy("Stamat");
            bool areValuesFound = false;

            if (collectionOfValues.Count != 0)
            {
                areValuesFound = true;
            }

            Assert.IsFalse(areValuesFound);
        }

        [TestMethod]
        public void FindBy_Key2_ExistingKey()
        {
            ICollection<string> collectionOfValues = this.biDictionary.FindBy(30);
            bool areValuesFind = true;

            if (collectionOfValues.Count == 2)
            {
                if (!collectionOfValues.Contains("Java") || !collectionOfValues.Contains("JavaScript"))
                {
                    areValuesFind = false;
                }
            }

            Assert.IsTrue(areValuesFind);
        }

        [TestMethod]
        public void FindBy_Key2_NonexistentKey()
        {
            ICollection<string> collectionOfValues = this.biDictionary.FindBy(11);
            bool areValuesFind = false;

            if (collectionOfValues.Count != 0)
            {
                areValuesFind = true;
            }

            Assert.IsFalse(areValuesFind);
        }

        [TestMethod]
        public void FindBy_Key1Key2_ExistingKeys()
        {
            ICollection<string> collectionOfValues = this.biDictionary.FindBy("Nakov", 33);
            bool isValueFind = true;

            if (collectionOfValues.Count == 1)
            {
                if (!collectionOfValues.Contains("XAML"))
                {
                    isValueFind = false;
                }
            }

            Assert.IsTrue(isValueFind);
        }

        [TestMethod]
        public void FindBy_Key1Key2_NonexistentKeys()
        {
            ICollection<string> collectionOfValues = this.biDictionary.FindBy("Katrin", 63);
            bool isValueFind = false;

            if (collectionOfValues.Count != 0)
            {
                isValueFind = true;
            }

            Assert.IsFalse(isValueFind);
        }

        [TestMethod]
        public void ContainsKey_Key1_True()
        {
            Assert.IsTrue(this.biDictionary.ContainsKey("Iva"));
        }

        [TestMethod]
        public void ContainsKey_Key1_False()
        {
            Assert.IsFalse(this.biDictionary.ContainsKey("Krisi"));
        }

        [TestMethod]
        public void ContainsKey_Key2_True()
        {
            Assert.IsTrue(this.biDictionary.ContainsKey(18));
        }

        [TestMethod]
        public void ContainsKey_Key2_False()
        {
            Assert.IsFalse(this.biDictionary.ContainsKey(44));
        }

        [TestMethod]
        public void Contains_Key1Key2Value_True()
        {
            Assert.IsTrue(this.biDictionary.Contains("Niki", 24, "WPF"));
        }

        [TestMethod]
        public void Contains_Key1Key2Value_False()
        {
            Assert.IsFalse(this.biDictionary.Contains("Milen", 14, "NodeJS"));
        }

        [TestMethod]
        public void Remove_ByKey1_True()
        {
            bool isKeyRemoved = this.biDictionary.Remove("Misho");

            if (this.biDictionary.ContainsKey("Misho"))
            {
                isKeyRemoved = false;
            }

            Assert.IsTrue(isKeyRemoved);
        }

        [TestMethod]
        public void Remove_ByKey1_False()
        {
            Assert.IsFalse(this.biDictionary.Remove("Drago"));
        }

        [TestMethod]
        public void Remove_ByKey2_True()
        {
            bool isKeyRemoved = this.biDictionary.Remove(30);

            if (this.biDictionary.ContainsKey(30))
            {
                isKeyRemoved = false;
            }

            Assert.IsTrue(isKeyRemoved);
        }

        [TestMethod]
        public void Remove_ByKey2_False()
        {
            Assert.IsFalse(this.biDictionary.Remove(111));
        }

        [TestMethod]
        public void Remove_ByKey1AndKey2_True()
        {
            bool areKeysRemoved = this.biDictionary.Remove("Iva", 18);

            if (this.biDictionary.Contains("Iva", 18, "XML"))
            {
                areKeysRemoved = false;
            }

            Assert.IsTrue(areKeysRemoved);
        }

        [TestMethod]
        public void Remove_ByKey1AndKey2_False()
        {
            Assert.IsFalse(this.biDictionary.Remove("Vasil", 13));
        }

        [TestMethod]
        public void Clear_RemoveAllKeysAndValues()
        {
            this.biDictionary.Clear();
            bool isBiDictionaryEmpty = true;

            if (this.biDictionary.Count != 0)
            {
                isBiDictionaryEmpty = false;
            }

            Assert.IsTrue(isBiDictionaryEmpty);
        }
    }
}
