using System;
using System.Collections.Generic;

namespace ProofOfConcept.LinkedLists
{
    public class DoublyLinkedList<T>
    {
        private Node head;
        private Node tail;

        public T this[int index] { get { return this.getItem(index); } set { this.setItem(index, value); } }

        public int Count { get; set; }

        public DoublyLinkedList(IEnumerable<T> collection) : this()
        {
            AddRange(collection);
        }

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public void AddBeg(T t)
        {
            if (head != null)
            {
                var current = head;
                head = new Node(t, null, current);
                current.Previous = head;
            }
            else
            {
                head = new Node(t);
                tail = head;
            }
            Count++;
        }

        public void AddEnd(T t)
        {
            if (Count > 0)
            {
                var n = new Node(t, tail);
                tail.Next = n;
                tail = n;
                Count++;
            }
            else AddBeg(t);
        }

        public void AddAt(int index, T t)
        {
            if (index > 0 && index < Count)
            {
                var right = getNode(index);
                var left = right.Previous;
                var n = new Node(t, left, right);
                left.Next = n;
                right.Previous = n;
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
                    head.Previous = null;
                    current.Next = null;
                }
                else head = tail = null;
                Count--;
            }
            else throw new ArgumentNullException();
        }

        public void RemoveEnd()
        {
            if (Count > 1)
            {
                var left = tail.Previous;
                left.Next = null;
                tail.Previous = null;
                tail = left;
                Count--;
            }
            else RemoveBeg();
        }

        public void RemoveAt(int index)
        {
            if (index > 0 && index < Count - 1)
            {
                var current = getNode(index);
                var left = current.Previous;
                var right = current.Next;
                left.Next = right;
                right.Previous = left;
                current.Previous = current.Next = null;
                Count--;
            }
            else if (index == 0) RemoveBeg();
            else if (index == Count - 1) RemoveEnd();
            else throw new IndexOutOfRangeException();
        }

        public void Remove(T t)
        {
            var current = head;
            var index = 0;
            while (current != null && !(t.Equals(current.Data)))
            {
                current = current.Next;
                index++;
            };
            if (Count > index) this.RemoveAt(index);
        }

        public void Clear()
        {
            for (int i = Count; i > 0; i--) this.RemoveBeg();
        }

        public bool Contains(T t)
        {
            var current = head;
            while (current != null)
            {
                if (t.Equals(current.Data)) return true;
                current = current.Next;
            };
            return false;
        }

        public T[] ToArray()
        {
            var array = new T[Count];
            var current = head;
            var index = 0;
            while (current != null)
            {
                array[index] = current.Data;
                current = current.Next;
                index++;
            };
            return array;
        }

        public override string ToString()
        {
            var s = "[";
            var current = head;
            var index = 0;
            while (current != null)
            {
                s += $"{index}: {current.Data}, ";
                current = current.Next;
                index++;
            };
            if (index > 0) s = s.Remove(s.Length - 2);
            s += "]";
            return s;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
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
            private Node previous;
            private Node next;
            private T data;

            public Node Previous { get { return previous; } set { previous = value; } }
            public Node Next { get { return next; } set { next = value; } }
            public T Data { get { return data; } set { data = value; } }

            public Node(T t) : this(t, null) { }

            public Node(T t, Node previous) : this(t, previous, null) { }

            public Node(T t, Node previous, Node next)
            {
                this.previous = previous;
                this.next = next;
                data = t;
            }
        }
    }
}