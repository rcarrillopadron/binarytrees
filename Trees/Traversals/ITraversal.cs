namespace Trees.Traversals
{
    internal interface ITraversal<T>
    {
        void Traverse(Node<T> node);
    }
}