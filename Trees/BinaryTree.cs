using System;
using System.Runtime.Remoting.Messaging;

namespace Trees
{
    internal class BinaryTree<T> where T : IComparable<T>
    {
        public Node<T> Root { get; set; }

        public void Add(T value)
        {
            if (Root == null)
            {
                Root = new Node<T>(value);
            }
            else
            {
                AddTo(Root, value);
            }
        }

        public Node<T> Find(T valueToFind)
        {
            return FindValue(Root, valueToFind);
        }

        private Node<T> FindValue(Node<T> node, T valueToFind)
        {
            throw new NotImplementedException();
        }

        private static void AddTo(Node<T> node, T value)
        {
            if (value.CompareTo(node.Value) < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new Node<T>(value);
                }
                else
                {
                    AddTo(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new Node<T>(value);
                }
                else
                {
                    AddTo(node.Right, value);
                }
            }
        }
    }
}