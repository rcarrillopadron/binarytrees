using System;
using Trees.Traversals;

namespace Trees
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Represents the following tree");
            Console.WriteLine(@"             4             ");
            Console.WriteLine(@"            / \            ");
            Console.WriteLine(@"           /   \           ");
            Console.WriteLine(@"          /     \          ");
            Console.WriteLine(@"         /       \         ");
            Console.WriteLine(@"        2         6        ");
            Console.WriteLine(@"       / \       / \       ");
            Console.WriteLine(@"      /   \     /   \      ");
            Console.WriteLine(@"     /     \   /     \     ");
            Console.WriteLine(@"     1     3   5     7     ");
            var binaryTree = new BinaryTree<int>();
            binaryTree.Add(4);
            binaryTree.Add(2);
            binaryTree.Add(6);
            binaryTree.Add(1);
            binaryTree.Add(3);
            binaryTree.Add(5);
            binaryTree.Add(7);

            var preOrderTraversal = new PreOrderTraversal<int>();
            Console.Write("PreOrder: ");
            preOrderTraversal.Traverse(binaryTree.Root);
            Console.WriteLine();

            Console.Write("InOrder: ");
            var inOrderTraversal = new PreOrderTraversal<int>();
            inOrderTraversal.Traverse(binaryTree.Root);
            Console.WriteLine();

            Console.Write("PostOrder: ");
            var postOrderTraversal = new PostOrderTraversal<int>();
            postOrderTraversal.Traverse(binaryTree.Root);
            Console.WriteLine();
        }
    }
}