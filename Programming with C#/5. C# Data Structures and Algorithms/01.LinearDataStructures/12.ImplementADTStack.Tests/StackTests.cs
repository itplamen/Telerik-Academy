namespace _12.ImplementADTStack.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StackTests
    {
        private Stack<string> stack;

        [TestInitialize]
        public void TestInitialize()
        {
            this.stack = new Stack<string>();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Push_TryToAddNullableElement()
        {
            this.stack.Push(null);
        }

        [TestMethod]
        public void Push_AddElements()
        {
            string[] array = { "delphy", "shell", "fortran", "svn", "git" };

            for (int i = 0; i < array.Length; i++)
            {
                this.stack.Push(array[i]);
            }

            bool expected = true;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] != this.stack.Pop())
                {
                    expected = false;
                    break;
                }
            }

            Assert.IsTrue(expected);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Pop_TryToRemoveAndReturnElementFromEmptyStack()
        {
            var topElement = this.stack.Pop();
        }

        [TestMethod]
        public void Pop_RemoveAndReturnElementFromTheTop()
        {
            this.stack.Push("msn");
            this.stack.Push("base");
            this.stack.Push("data");

            var topElement = "data";
            Assert.AreEqual(topElement, this.stack.Pop());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Peek_TryToReturnElementFromEmptyStack()
        {
            var topElement = this.stack.Peek();
        }

        [TestMethod]
        public void Peek_ReturnElementFromEmptyStack()
        {
            this.stack.Push("msn");
            this.stack.Push("base");
            this.stack.Push("data");

            var topElement = "data";
            Assert.AreEqual(topElement, this.stack.Peek());
        }

        [TestMethod]
        public void Clear_RemoveAllElements()
        {
            string[] array = { "delphy", "shell", "fortran", "svn", "git" };

            for (int i = 0; i < array.Length; i++)
            {
                this.stack.Push(array[i]);
            }

            this.stack.Clear();
            int expectedNumberOfElements = 0;
            Assert.AreEqual(expectedNumberOfElements, this.stack.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Contains_NullableElement()
        {
            this.stack.Contains(null);
        }

        [TestMethod]
        public void Contains_ExistElement()
        {
            this.stack.Push("msn");
            this.stack.Push("base");
            this.stack.Push("data");
            Assert.IsTrue(this.stack.Contains("base"));
        }

        [TestMethod]
        public void Contains_NonexistElement()
        {
            this.stack.Push("msn");
            this.stack.Push("base");
            this.stack.Push("data");
            Assert.IsFalse(this.stack.Contains("git"));
        }

        [TestMethod]
        public void ToArray_ConvertStackToArray()
        {
            this.stack.Push("msn");
            this.stack.Push("base");
            this.stack.Push("data");

            string[] array = this.stack.ToArray();
            bool areElementsEqual = true;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (this.stack.Pop() != array[i])
                {
                    areElementsEqual = false;
                    break;
                }
            }

            Assert.IsTrue(areElementsEqual);
        }

        [TestMethod]
        public void TrimExcess_SetStackCapacity()
        {
            this.stack.Push("msn");
            this.stack.TrimExcess();
            Assert.AreEqual(this.stack.Count, this.stack.Capacity);
        }

        [TestMethod]
        public void GetEnumerator_TestForeach()
        {
            this.stack.Push("msn");
            this.stack.Push("base");
            this.stack.Push("data");

            bool expected = true;
            foreach (var item in this.stack)
            {
                if (item != this.stack.Pop())
                {
                    expected = false;
                    break;
                }
            }

            Assert.IsTrue(expected);
        }
    }
}
