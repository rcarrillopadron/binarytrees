﻿namespace Trees
{
    internal class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        }

        public T Value { get; private set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
    }
}