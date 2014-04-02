using System;

namespace Trees.Traversals
{
    internal class InOrderTraversal<T> : ITraversal<T>
    {
        public void Traverse(Node<T> node)
        {
            if (node == null)
            {
                return;
            }

            Traverse(node.Left);
            Console.Write("{0} ", node.Value);
            Traverse(node.Right);
        }
    }
}