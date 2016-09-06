using System;
using System.Collections.Generic;

namespace ProofOfConcept.LinkedLists
{
    public class CircularLinkedList<T>
    {
        private Node head;

        public T this[int index] { get { return this.getItem(index); } set { this.setItem(index, value); } }

        public int Count { get; set; }

        public CircularLinkedList(IEnumerable<T> collection) : this()
        {
            AddRange(collection);
        }

        public CircularLinkedList()
        {
            head = null;
            Count = 0;
        }

        public void AddBeg(T t)
        {
            head = new Node(t, head);
            Count++;
            getNode(Count - 1).Next = head;
        }

        public void AddEnd(T t)
        {
            if (Count > 0)
            {
                getNode(Count - 1).Next = new Node(t, head);
                Count++;
            }
            else AddBeg(t);
        }

        public void AddAt(int index, T t)
        {
            if (index > 0 && index < Count)
            {
                var left = getNode(index - 1);
                left.Next = new Node(t, left.Next);
                Count++;
            }
            else if (index == 0) AddBeg(t);
            else if (index == Count) AddEnd(t);
            else throw new IndexOutOfRangeException();
        }

        public void Add(T t)
        {
            AddEnd(t);
        }

        public void AddRange(IEnumerable<T> collection)
        {
            foreach (T t in collection) this.AddEnd(t);
        }

        public void RemoveBeg()
        {
            if (head != null)
            {
                if (head.Next != null)
                {
                    var current = head;
                    head = current.Next;
                    current.Next = null;
                    Count--;
                    getNode(Count - 1).Next = head;
                }
                else
                {
                    head.Next = null;
                    head = null;
                    Count--;
                }
            }
            else throw new ArgumentNullException();
        }

        public void RemoveEnd()
        {
            if (Count > 1)
            {
                var left = getNode(Count - 2);
                var last = left.Next;
                left.Next = head;
                last.Next = null;
                Count--;
            }
            else RemoveBeg();
        }

        public void RemoveAt(int index)
        {
            if (index > 0 && index < Count - 1)
            {
                var left = getNode(index - 1);
                var current = left.Next;
                var right = current.Next;
                left.Next = right;
                current.Next = null;
                Count--;
            }
            else if (index == 0) RemoveBeg();
            else if (index == Count - 1) RemoveEnd();
            else throw new IndexOutOfRangeException();
        }

        public void Remove(T t)
        {
            if (head != null)
            {
                var current = head;
                var index = 0;
                var working = true;
                do
                {
                    if (t.Equals(current.Data)) working = false;
                    else
                    {
                        current = current.Next;
                        index++;
                    }
                } while (working && current != head);
                if (Count > index) this.RemoveAt(index);
            }
        }

        public void Clear()
        {
            for (int i = Count; i > 0; i--) this.RemoveBeg();
        }

        public bool Contains(T t)
        {
            if (head != null)
            {
                var current = head;
                do
                {
                    if (t.Equals(current.Data)) return true;
                    current = current.Next;
                } while (current != head);
            }
            return false;
        }

        public T[] ToArray()
        {
            var array = new T[Count];
            if (head != null)
            {
                var current = head;
                var index = 0;
                do
                {
                    array[index] = current.Data;
                    current = current.Next;
                    index++;
                } while (current != head);
            }
            return array;
        }

        public override string ToString()
        {
            var s = "[";
            if (head != null)
            {
                var current = head;
                var index = 0;
                do
                {
                    s += $"{index}: {current.Data}, ";
                    current = current.Next;
                    index++;
                } while (current != head);
                s = s.Remove(s.Length - 2);
            }
            s += "]";
            return s;
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (head != null)
            {
                var current = head;
                do
                {
                    yield return current.Data;
                    current = current.Next;
                } while (current != head);
            }
        }

        private Node getNode(int index)
        {
            if (index >= 0 && index < Count)
            {
                var node = head;
                for (var i = 0; i < index; i++) node = node.Next;
                return node;
            }
            else throw new IndexOutOfRangeException();
        }

        private T getItem(int index)
        {
            return getNode(index).Data;
        }

        private void setItem(int index, T t)
        {
            getNode(index).Data = t;
        }

        private class Node
        {
            private Node next;
            private T data;

            public Node Next { get { return next; } set { next = value; } }
            public T Data { get { return data; } set { data = value; } }

            public Node(T t) : this(t, null) { }

            public Node(T t, Node next)
            {
                this.next = next;
                this.data = t;
            }
        }
    }
}