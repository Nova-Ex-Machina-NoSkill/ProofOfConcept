using System;

namespace ProofOfConcept.Tree
{
    public class BST<T> where T : IComparable
    {
        private Node root;

        public BST()
        {
            root = null;
        }

        public void Insert(T t)
        {
            if (root != null)
            {
                var current = root;
                while (true)
                {
                    if (t.CompareTo(current.Data) < 1)
                    {
                        if (current.LeftChild != null) current = current.LeftChild;
                        else
                        {
                            current.LeftChild = new Node(t);
                            break;
                        }
                    }
                    else
                    {
                        if (current.RightChild != null) current = current.RightChild;
                        else
                        {
                            current.RightChild = new Node(t);
                            break;
                        }
                    }
                }
            }
            else root = new Node(t);
        }

        private Node Search(T t)
        {
            var current = root;
            while(current != null)
            {
                var result = t.CompareTo(current.Data);
                if (result == 0) return current;
                else if (result == -1) current = current.LeftChild;
                else current = current.RightChild;
            };
            return current;
        }

        private class Node
        {
            private T data;
            private Node leftChild;
            private Node rightChild;

            public T Data { get { return data; } set { data = value; } }
            public Node LeftChild { get { return leftChild; } set { leftChild = value; } }
            public Node RightChild { get { return rightChild; } set { rightChild = value; } }

            public Node(T data) : this(data, null, null) { }

            public Node(T data, Node leftChild) : this(data, leftChild, null) { }

            public Node(T data, Node leftChild, Node rightChild)
            {
                this.data = data;
                this.leftChild = leftChild;
                this.rightChild = rightChild;
            }
        }
    }
}