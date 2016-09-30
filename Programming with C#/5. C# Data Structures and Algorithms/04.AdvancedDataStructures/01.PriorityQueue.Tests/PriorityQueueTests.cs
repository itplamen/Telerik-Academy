namespace _01.PriorityQueue.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PriorityQueueTests
    {
        private PriorityQueue<int> priorityQueue;

        [TestInitialize]
        public void TestInitialize()
        {
            this.priorityQueue = new PriorityQueue<int>();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Enqueue_NullElement()
        {
            PriorityQueue<string> queue = new PriorityQueue<string>();
            queue.Enqueue(null);
        }

        [TestMethod]
        public void Enqueue_AddElementsWithoutSwapingElements()
        {
            this.priorityQueue.Enqueue(1);
            this.priorityQueue.Enqueue(3);
            this.priorityQueue.Enqueue(2);

            string expected = "1, 3, 2";
            Assert.AreEqual(expected, this.priorityQueue.ToString());
        }

        [TestMethod]
        public void Enqueue_AddElementsWithSwapingElements()
        {
            this.priorityQueue.Enqueue(1);
            this.priorityQueue.Enqueue(3);
            this.priorityQueue.Enqueue(2);
            this.priorityQueue.Enqueue(5);
            this.priorityQueue.Enqueue(4);
            this.priorityQueue.Enqueue(6);
            this.priorityQueue.Enqueue(0);

            string expected = "0, 3, 1, 5, 4, 6, 2";
            Assert.AreEqual(expected, this.priorityQueue.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Dequeue_EmptyPriorityQueue()
        {
            this.priorityQueue.Dequeue();
        }

        [TestMethod]
        public void Dequeue_ReturnTopElement()
        {
            this.priorityQueue.Enqueue(3);
            this.priorityQueue.Enqueue(5);
            this.priorityQueue.Enqueue(4);

            int expectedElement = 3;
            Assert.AreEqual(expectedElement, this.priorityQueue.Dequeue());
        }

        [TestMethod]
        public void Dequeue_RemoveTopElement()
        {
            this.priorityQueue.Enqueue(3);
            this.priorityQueue.Enqueue(5);
            this.priorityQueue.Enqueue(4);

            this.priorityQueue.Dequeue();
            Assert.IsFalse(this.priorityQueue.Contains(3));
        }

        [TestMethod]
        public void Dequeue_SwapingElements()
        {
            this.priorityQueue.Enqueue(3);
            this.priorityQueue.Enqueue(5);
            this.priorityQueue.Enqueue(4);
            this.priorityQueue.Enqueue(6);
            this.priorityQueue.Enqueue(7);
            this.priorityQueue.Enqueue(8);
            this.priorityQueue.Enqueue(9);
            this.priorityQueue.Enqueue(10);
            this.priorityQueue.Enqueue(11);
            this.priorityQueue.Enqueue(13);
            this.priorityQueue.Enqueue(12);
            this.priorityQueue.Enqueue(14);
            this.priorityQueue.Enqueue(15);
            this.priorityQueue.Enqueue(17);
            this.priorityQueue.Enqueue(16);

            this.priorityQueue.Dequeue();
            string expected = "4, 5, 8, 6, 7, 14, 9, 10, 11, 13, 12, 16, 15, 17";
            Assert.AreEqual(expected, this.priorityQueue.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Peek_EmptyPriorityQueue()
        {
            this.priorityQueue.Peek();
        }

        [TestMethod]
        public void Peek_ReturnTheTopELement()
        {
            this.priorityQueue.Enqueue(3);
            this.priorityQueue.Enqueue(5);
            this.priorityQueue.Enqueue(4);

            int expectedElement = 3;
            Assert.AreEqual(expectedElement, this.priorityQueue.Peek());
        }

        [TestMethod]
        public void Clear_RemoveAllElements()
        {
            this.priorityQueue.Enqueue(3);
            this.priorityQueue.Enqueue(5);
            this.priorityQueue.Enqueue(4);

            this.priorityQueue.Clear();
            int expectedNumberOfElements = 0;
            Assert.AreEqual(expectedNumberOfElements, this.priorityQueue.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Contains_EmptypPiorityQueue()
        {
            this.priorityQueue.Contains(-13);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Contains_NullableElement()
        {
            PriorityQueue<string> queue = new PriorityQueue<string>();
            queue.Enqueue("f#");
            queue.Contains(null);
        }

        [TestMethod]
        public void Contains_True()
        {
            this.priorityQueue.Enqueue(3);
            this.priorityQueue.Enqueue(5);
            this.priorityQueue.Enqueue(4);
            Assert.IsTrue(this.priorityQueue.Contains(4));
        }

        [TestMethod]
        public void Contains_False()
        {
            this.priorityQueue.Enqueue(3);
            this.priorityQueue.Enqueue(5);
            this.priorityQueue.Enqueue(4);
            Assert.IsFalse(this.priorityQueue.Contains(11));
        }

        [TestMethod]
        public void ToArray_ReturnArrayWithElementsFromTheQueue()
        {
            this.priorityQueue.Enqueue(3);
            this.priorityQueue.Enqueue(5);
            this.priorityQueue.Enqueue(4);

            int[] array = this.priorityQueue.ToArray();
            bool areElementsInArray = false;

            while (this.priorityQueue.Count > 0)
            {
                var element = this.priorityQueue.Dequeue();

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == element)
                    {
                        areElementsInArray = true;
                    }
                }
            }

            Assert.IsTrue(areElementsInArray);
        }

        [TestMethod]
        public void ToString_PrintElement()
        {
            this.priorityQueue.Enqueue(3);
            this.priorityQueue.Enqueue(5);
            this.priorityQueue.Enqueue(4);

            string expected = "3, 5, 4";
            Assert.AreEqual(expected, this.priorityQueue.ToString());
        }
    }
}
