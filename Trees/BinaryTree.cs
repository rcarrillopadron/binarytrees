using System;

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

        private static Node<T> FindValue(Node<T> node, T valueToFind)
        {
            if (node == null)
                return null;
            
            if (valueToFind.CompareTo(node.Value) == 0)
                return node;

            if (valueToFind.CompareTo(node.Value) < 0)
                return FindValue(node.Left, valueToFind);
            
            return FindValue(node.Right, valueToFind);
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