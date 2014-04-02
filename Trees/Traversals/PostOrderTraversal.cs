using System;

namespace Trees.Traversals
{
    internal class PostOrderTraversal<T> : ITraversal<T>
    {
        public void Traverse(Node<T> node)
        {
            if (node == null)
            {
                return;
            }

            Traverse(node.Left);
            Traverse(node.Right);
            Console.Write("{0} ", node.Value);
        }
    }
}