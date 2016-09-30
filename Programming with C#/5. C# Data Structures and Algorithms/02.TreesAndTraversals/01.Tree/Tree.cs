//01.You are given a tree of N nodes represented as a set of N-1 pairs of nodes (parent node, child node), each in the range (0..N-1).
//Write a program to read the tree and find:
//а) the root node
//b) all leaf nodes
//c) all middle nodes
//d) the longest path in the tree
//i) * all paths in the tree with given sum S of their nodes
//f) * all subtrees with given sum S of their nodes

namespace _01.Tree
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Tree
    {
        private static int longestPath = 0;
        private static int currentSumOfNodes = 0;
        private static IList<Node<int>> paths = new List<Node<int>>();
        private static IList<Node<int>> currentPath = new List<Node<int>>();

        public static Node<int> FindRoot(Node<int>[] nodes)
        {
            Node<int> root = null;

            foreach (Node<int> node in nodes)
            {
                if (node.HasParrent != true)
                {
                    root = node;
                }
            }

            return root;
        }

        public static IList<Node<int>> FindAllLeafNodes(Node<int>[] nodes)
        {
            IList<Node<int>> leafNodes = new List<Node<int>>();

            foreach (Node<int> node in nodes)
            {
                if (node.Childrens.Count == 0)
                {
                    leafNodes.Add(node);
                }
            }

            return leafNodes;
        }

        public static IList<Node<int>> FindAllMiddleNodes(Node<int>[] nodes)
        {
            IList<Node<int>> middleNodes = new List<Node<int>>();

            foreach (Node<int> node in nodes)
            {
                if (node.Childrens.Count > 0 && node.HasParrent == true)
                {
                    middleNodes.Add(node);
                }
            }

            return middleNodes;
        }

        public static void FindLongestPath(Node<int> root)
        {
            currentSumOfNodes += root.Value;

            if (root.Childrens.Count == 0)
            {
                if (currentSumOfNodes > longestPath)
                {
                    longestPath = currentSumOfNodes;
                }

                return;
            }

            for (int i = 0; i < root.Childrens.Count; i++)
            {
                FindLongestPath(root.Childrens[i]);
                currentSumOfNodes -= root.Childrens[i].Value;
            }
        }

        public static void FindAllPathsWithGivenSum(Node<int> root, int sum, int currentSum)
        {
            currentPath.Add(root);
            currentSum += root.Value;

            // If leaf is reached.
            if (root.Childrens.Count == 0)
            {
                if (currentSum == sum)
                {
                    for (int i = 0; i < currentPath.Count; i++)
                    {
                        paths.Add(currentPath[i]);
                    }
                }

                return;
            }

            for (int i = 0; i < root.Childrens.Count; i++)
            {
                FindAllPathsWithGivenSum(root.Childrens[i], sum, currentSum);

                // Remove the last added node.
                currentPath.RemoveAt(currentPath.Count - 1);
            }
        }

        public static void PrintNodes(IList<Node<int>> arrayOfNodes)
        {
            for (int i = 0; i < arrayOfNodes.Count; i++)
            {
                Console.Write(arrayOfNodes[i].Value + " ");
            }
            
            Console.WriteLine("\n");
        }

        public static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("input1.txt");
            Node<int>[] arrayOfNodes = null;

            using (reader)
            {
                string line = reader.ReadLine();
                arrayOfNodes = new Node<int>[int.Parse(line)];

                for (int i = 0; i < arrayOfNodes.Length; i++)
                {
                    arrayOfNodes[i] = new Node<int>(i);
                }

                line = reader.ReadLine();

                while (line != null)
                {
                    int parrentNode = int.Parse(line.Split(' ')[0]);
                    int childNode = int.Parse(line.Split(' ')[1]);
                    arrayOfNodes[parrentNode].AddChildren(arrayOfNodes[childNode]);
                    arrayOfNodes[childNode].HasParrent = true;
                    line = reader.ReadLine();
                }
            }

            // а) Find root.
            Node<int> root = FindRoot(arrayOfNodes);
            Console.WriteLine("---------- a) Find root ----------");
            Console.WriteLine("Tree root is: " + root.Value + "\n");

            // b) Find all leaf nodes.
            Console.WriteLine("---------- b) Find all leaf nodes ----------");
            Console.Write("All leaf nodes are: ");
            PrintNodes(FindAllLeafNodes(arrayOfNodes));

            // c) Find all middle nodes.
            Console.WriteLine("---------- c) Find all middle nodes ----------");
            Console.Write("All middle nodes are: ");
            PrintNodes(FindAllMiddleNodes(arrayOfNodes));

            // d) Find the longest path in the tree.
            FindLongestPath(root);
            Console.WriteLine("---------- d) Find the longest path in the tree ----------");
            Console.Write("Longest path is: " + longestPath);
            Console.WriteLine("\n");

            // i) * Find all paths in the tree with given sum S of their nodes.
            Console.WriteLine("----- i) * Find all paths in the tree with given sum S of their nodes -----");
            Console.Write("Enter sum: ");
            int sum = int.Parse(Console.ReadLine());
            FindAllPathsWithGivenSum(root, sum, 0);

            if (paths.Count != 0)
            {
                Console.Write("Paths are: ");
                for (int i = 0; i < paths.Count; i++)
                {
                    if (paths[i].Value == root.Value && i != 0)
                    {
                        Console.Write(", ");
                    }

                    Console.Write(paths[i].Value + " ");
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There is no paths with sum {0} of their nodes!", sum);
            }
        }
    }
}
