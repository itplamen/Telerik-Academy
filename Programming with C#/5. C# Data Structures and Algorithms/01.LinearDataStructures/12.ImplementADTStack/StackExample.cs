//12.Implement the ADT stack as auto-resizable array. Resize the capacity on demand (when no space is available to add / insert a new element).

namespace _12.ImplementADTStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StackExample
    {
        public static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Telerik");
            stack.Push(".Net");
            stack.Push("Build");
            stack.Push("Git");
            stack.Push("C#");
            stack.Push("CLR");

            Console.WriteLine("Number of elements in the stack: " + stack.Count);
            Console.WriteLine("Top element in the stack is:  " + stack.Peek());
            Console.WriteLine("Is the stack contains element \"Git\": " + stack.Contains("Git"));
            
            Console.WriteLine("Print and remove top element in the stack...");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.WriteLine("Number of elements in the stack after removed them: " + stack.Count + "\n");

            stack.Push("Test");
            stack.Push("CTS");
            stack.Push("Compiler");

            var array = stack.ToArray();
            Console.WriteLine("Print array elements...");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine();

            stack.TrimExcess();
            stack.Clear();
            Console.WriteLine("Number of elements in the stack after calling Clear method: " + stack.Count + "\n");
        }
    }
}
