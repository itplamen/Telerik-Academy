namespace _13.ImplementADTQueueAsDynamicLinkedList.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LinkedQueueTests
    {
        private LinkedQueue<string> linkedQueue;

        [TestInitialize]
        public void TestInitialize()
        {
            this.linkedQueue = new LinkedQueue<string>();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Enqueue_NullableElement()
        {
            this.linkedQueue.Enqueue(null);
        }

        [TestMethod]
        public void Enqueue_AddElementAtTheHead()
        {
            var firstElement = "unix";
            this.linkedQueue.Enqueue(firstElement);

            bool isElementAtTheHead = true;

            if (this.linkedQueue.Count != 1 && this.linkedQueue.Peek() != firstElement)
            {
                isElementAtTheHead = false;
            }

            Assert.IsTrue(isElementAtTheHead);
        }

        [TestMethod]
        public void Enqueue_AddElements()
        {
            string[] array = { "linux", "unix", "windows" };

            for (int i = 0; i < array.Length; i++)
            {
                this.linkedQueue.Enqueue(array[i]);
            }

            bool isQueueContainsElements = true;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != this.linkedQueue.Dequeue())
                {
                    isQueueContainsElements = false;
                }
            }

            Assert.IsTrue(isQueueContainsElements);
        }
        
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Dequeue_EmptyQueue()
        {
            this.linkedQueue.Dequeue();
        }

        [TestMethod]
        public void Dequeue_RemoveAndReturnFirstElement()
        {
            this.linkedQueue.Enqueue("github");
            this.linkedQueue.Enqueue("Class");
            this.linkedQueue.Enqueue("array");

            var firstElement = this.linkedQueue.Dequeue();
            bool isFirstElementRemoved = true;

            foreach (var element in this.linkedQueue)
            {
                if (element == firstElement)
                {
                    isFirstElementRemoved = false;
                    break;
                }
            }

            Assert.IsTrue(isFirstElementRemoved);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Peek_EmptyQueue()
        {
            this.linkedQueue.Peek();
        }

        [TestMethod]
        public void Peek_ReturnFirstElement()
        {
            this.linkedQueue.Enqueue("github");
            this.linkedQueue.Enqueue("Class");
            this.linkedQueue.Enqueue("array");

            var expectedFirstElement = "github";
            Assert.AreEqual(expectedFirstElement, this.linkedQueue.Peek());
        }

        [TestMethod]
        public void Clear_RemoveAllElementsFromTheQueue()
        {
            this.linkedQueue.Enqueue("github");
            this.linkedQueue.Enqueue("Class");
            this.linkedQueue.Enqueue("array");
            this.linkedQueue.Clear();

            int expectedNumberOfElements = 0;
            Assert.AreEqual(expectedNumberOfElements, this.linkedQueue.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Contains_NullElements()
        {
            this.linkedQueue.Contains(null);
        }

        [TestMethod]
        public void Contains_ExistElement()
        {
            this.linkedQueue.Enqueue("github");
            this.linkedQueue.Enqueue("Class");
            this.linkedQueue.Enqueue("array");
            Assert.IsTrue(this.linkedQueue.Contains("array"));
        }

        [TestMethod]
        public void Contains_NonexistElement()
        {
            this.linkedQueue.Enqueue("github");
            this.linkedQueue.Enqueue("Class");
            this.linkedQueue.Enqueue("array");
            Assert.IsFalse(this.linkedQueue.Contains("java"));
        }

        [TestMethod]
        public void ToArray_ConvertQueueToArray()
        {
            this.linkedQueue.Enqueue("github");
            this.linkedQueue.Enqueue("Class");
            this.linkedQueue.Enqueue("array");

            string[] array = this.linkedQueue.ToArray();
            bool isConverted = true;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != this.linkedQueue.Dequeue())
                {
                    isConverted = false;
                    break;
                }
            }

            Assert.IsTrue(isConverted);
        }

        [TestMethod]
        public void ToString_PrintQueueElements()
        {
            this.linkedQueue.Enqueue("github");
            this.linkedQueue.Enqueue("Class");
            this.linkedQueue.Enqueue("array");
            var expected = "github Class array";
            Assert.AreEqual(expected, this.linkedQueue.ToString());
        }

        [TestMethod]
        public void GetEnumerator_TestForeachLoop()
        {
            string[] array = { "linux", "unix", "windows" };

            for (int i = 0; i < array.Length; i++)
            {
                this.linkedQueue.Enqueue(array[i]);
            }

            bool result = true;
            int index = 0;

            foreach (var element in this.linkedQueue)
            {
                if (array[index] != element)
                {
                    result = false;
                    break;
                }

                index++;
            }

            Assert.IsTrue(result);
        }
    }
}
