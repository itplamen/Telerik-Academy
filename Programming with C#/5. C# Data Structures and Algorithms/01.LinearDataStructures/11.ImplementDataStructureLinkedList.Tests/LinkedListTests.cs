namespace _11.ImplementDataStructureLinkedList.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LinkedListTests
    {
        private LinkedList<string> linkedList;

        [TestInitialize]
        public void TestInitialize()
        {
            this.linkedList = new LinkedList<string>();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_ReturnInvalidValue()
        {
            this.linkedList.Add("Asus");
            var element = this.linkedList[3];
        }

        [TestMethod]
        public void Indexer_ReturnValidElement()
        {
            this.linkedList.Add("debug");
            this.linkedList.Add("build");
            var expected = "build";
            Assert.AreEqual(expected, this.linkedList[1]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_SetInvalidElement()
        {
            this.linkedList.Add("project");
            this.linkedList[-1] = "test";
        }

        [TestMethod]
        public void Indexer_SetValidElement()
        {
            this.linkedList.Add("project");
            this.linkedList.Add("project");
            this.linkedList.Add("project");
            this.linkedList[2] = "hp";
            var expected = "hp";
            Assert.AreEqual(expected, this.linkedList[2]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Add_NullableElement()
        {
            this.linkedList.Add(null);
        }

        [TestMethod]
        public void Add_AddElements()
        {
            string[] array = { "C#", "Java", "C++" };

            for (int i = 0; i < array.Length; i++)
            {
                this.linkedList.Add(array[i]);
            }

            bool expectedResult = true;

            for (int i = 0; i < this.linkedList.Count; i++)
            {
                if (this.linkedList[i] != array[i])
                {
                    expectedResult = false;
                    break;
                }
            }

            Assert.IsTrue(expectedResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Insert_InvalidIndex()
        {
            this.linkedList.Add("linux");
            this.linkedList.Add("unix");
            this.linkedList.Add("array");
            this.linkedList.Insert(4, "IL");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Insert_InvalidElement()
        {
            this.linkedList.Add("linux");
            this.linkedList.Add("unix");
            this.linkedList.Add("array");
            this.linkedList.Insert(1, null);
        }

        [TestMethod]
        public void Insert_InsertElementAtTheHead()
        {
            this.linkedList.Add("linux");
            this.linkedList.Add("unix");
            this.linkedList.Add("array");
            this.linkedList.Insert(0, "mac");

            var expected = "mac";
            Assert.AreEqual(expected, this.linkedList[0]);
        }

        [TestMethod]
        public void Insert_InsertElementAtTheEnd()
        {
            this.linkedList.Add("linux");
            this.linkedList.Add("unix");
            this.linkedList.Add("array");
            this.linkedList.Insert(2, "mac");

            var expected = "mac";
            Assert.AreEqual(expected, this.linkedList[3]);
        }

        [TestMethod]
        public void Insert_InsertElementAtTheSpecifiedPosition()
        {
            this.linkedList.Add("linux");
            this.linkedList.Add("unix");
            this.linkedList.Add("array");
            this.linkedList.Add("class");
            this.linkedList.Add("enum");
            this.linkedList.Insert(2, "mac");

            var expected = "mac";
            Assert.AreEqual(expected, this.linkedList[2]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Remove_NullableElement()
        {
            this.linkedList.Add("xp");
            this.linkedList.Remove(null);
        }

        [TestMethod]
        public void Remove_NotExistElement()
        {
            this.linkedList.Add("xp");
            bool isElementRemoved = this.linkedList.Remove("asp");
            Assert.IsFalse(isElementRemoved);
        }

        [TestMethod]
        public void Remove_RemoveElementFromTheHead()
        {
            this.linkedList.Add("xp");
            this.linkedList.Add(".net");
            this.linkedList.Add("framework");
            this.linkedList.Remove("xp");

            var expected = ".net";
            var headElement = this.linkedList[0];
            Assert.AreEqual(expected, headElement);
        }

        [TestMethod]
        public void Remove_RemoveElementFromTheEnd()
        {
            this.linkedList.Add("xp");
            this.linkedList.Add(".net");
            this.linkedList.Add("framework");
            this.linkedList.Remove("framework");

            var expected = ".net";
            var lastElement = this.linkedList[1];
            Assert.AreEqual(expected, lastElement);
        }

        [TestMethod]
        public void Remove_RemoveElementFromTheSpecifiedPosition()
        {
            this.linkedList.Add("xp");
            this.linkedList.Add(".net");
            this.linkedList.Add("framework");
            this.linkedList.Remove(".net");
            Assert.IsFalse(this.linkedList.Contains(".net"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAt_InvalidIndex()
        {
            this.linkedList.Add("xp");
            this.linkedList.Add(".net");
            this.linkedList.RemoveAt(-1);
        }

        [TestMethod]
        public void RemoveAt_RemoveElementAtTheSpecifiedIndex()
        {
            this.linkedList.Add("xp");
            this.linkedList.Add(".net");
            this.linkedList.Add("IL");
            this.linkedList.RemoveAt(1);
        }

        [TestMethod]
        public void Clear_ClearAllElement()
        {
            this.linkedList.Add("xp");
            this.linkedList.Clear();

            bool isListEmpty = true;

            if (this.linkedList.Count != 0 || this.linkedList.Contains("xp") == true)
            {
                isListEmpty = false;
            }

            Assert.IsTrue(isListEmpty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Contains_NullableElemen()
        {
            this.linkedList.Add("xp");
            this.linkedList.Add(".net");
            this.linkedList.Add("IL");
            this.linkedList.Contains(null);
        }

        [TestMethod]
        public void Contains_True()
        {
            this.linkedList.Add("xp");
            this.linkedList.Add(".net");
            this.linkedList.Add("IL");
            Assert.IsTrue(this.linkedList.Contains("IL"));
        }

        [TestMethod]
        public void Contains_False()
        {
            this.linkedList.Add("xp");
            this.linkedList.Add(".net");
            this.linkedList.Add("IL");
            Assert.IsFalse(this.linkedList.Contains("mono"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IndexOf_NullableElement()
        {
            this.linkedList.Add("xp");
            this.linkedList.Add(".net");
            this.linkedList.Add("IL");
            this.linkedList.IndexOf(null);
        }

        [TestMethod]
        public void IndexOf_ReturnIndexOfTheElement()
        {
            this.linkedList.Add("xp");
            this.linkedList.Add(".net");
            this.linkedList.Add("IL");

            var expectedIndex = 2;
            Assert.AreEqual(expectedIndex, this.linkedList.IndexOf("IL"));
        }

        [TestMethod]
        public void IndexOf_IfListDoesntContainsTheElement()
        {
            this.linkedList.Add("xp");
            this.linkedList.Add(".net");
            this.linkedList.Add("IL");

            var expectedIndex = -1;
            Assert.AreEqual(expectedIndex, this.linkedList.IndexOf("basic"));
        }

        [TestMethod]
        public void ToArray_ConvertListToArray()
        {
            this.linkedList.Add("xp");
            this.linkedList.Add(".net");
            this.linkedList.Add("IL");

            string[] array = this.linkedList.ToArray();
            bool expected = true;

            for (int i = 0; i < this.linkedList.Count; i++)
            {
                if (this.linkedList[i] != array[i])
                {
                    expected = false;
                    break;
                }
            }

            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void Reverse_ReverseElementsOrder()
        {
            this.linkedList.Add("xp");
            this.linkedList.Add(".net");
            this.linkedList.Add("IL");
            this.linkedList.Reverse();

            string[] array = { "IL", ".net", "xp" };
            bool areElementsReversed = true;

            for (int i = 0; i < this.linkedList.Count; i++)
            {
                if (this.linkedList[i] != array[i])
                {
                    areElementsReversed = false;
                    break;
                }
            }

            Assert.IsTrue(areElementsReversed);
        }

        [TestMethod]
        public void Sort_SortElementsInAscendingOrder()
        {
            this.linkedList.Add("xp");
            this.linkedList.Add("app");
            this.linkedList.Add("IL");
            this.linkedList.Sort();

            string[] sortedElements = { "app", "IL", "xp" };
            bool areElementsSorted = true;

            for (int i = 0; i < this.linkedList.Count; i++)
            {
                if (this.linkedList[i] != sortedElements[i])
                {
                    areElementsSorted = false;
                    break;
                }
            }

            Assert.IsTrue(areElementsSorted);
        }

        [TestMethod]
        public void ToString_PrintElements()
        {
            this.linkedList.Add("xp");
            this.linkedList.Add("app");
            this.linkedList.Add("IL");

            var expected = "xp app IL";
            var result = this.linkedList.ToString();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetEnumerator_TestForeachLoop()
        {
            this.linkedList.Add("xp");
            this.linkedList.Add("app");
            this.linkedList.Add("IL");
            
            string[] array = { "xp", "app", "IL" };
            int index = 0;
            bool expected = true;

            foreach (var item in this.linkedList)
            {
                if (item != array[index])
                {
                    expected = false;
                }

                index++;
            }

            Assert.IsTrue(expected);
        }
    }
}
