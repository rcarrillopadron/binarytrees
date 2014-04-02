using System;

namespace Trees.Traversals
{
    internal class PreOrderTraversal<T> : ITraversal<T>
    {
        public void Traverse(Node<T> node)
        {
            if (node == null)
            {
                return;
            }

            Console.Write("{0} ", node.Value);
            Traverse(node.Left);
            Traverse(node.Right);
        }
    }
}