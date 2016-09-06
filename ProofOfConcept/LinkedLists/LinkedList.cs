using System;
using System.Collections.Generic;

namespace ProofOfConcept.LinkedLists
{
    public class LinkedList<T>
    {
        private Node head;

        public T this[int index] { get { return this.getItem(index); } set { this.setItem(index, value); } }
        
        public int Count { get; set; }

        public LinkedList(IEnumerable<T> collection) : this()
        {
            AddRange(collection);
        }

        public LinkedList()
        {
            head = null;
            Count = 0;
        }

        public void AddBeg(T t)
        {
            head = new Node(t, head);
            Count++;
        }

        public void AddEnd(T t)
        {
            if (Count > 0)
            {
                getNode(Count - 1).Next = new Node(t);
                Count++;
            }
            else AddBeg(t);
        }

        public void AddAt(int index, T t)
        {
            if (index > 0 && index < Count)
            {
                var left = getNode(index - 1);
                var current = left.Next;
                left.Next = new Node(t, current);
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
                var current = head;
                var right = current.Next;
                head = right;
                current.Next = null;
                Count--;
            }
            else throw new ArgumentNullException();
        }

        public void RemoveEnd()
        {
            if (Count > 1)
            {
                getNode(Count - 2).Next = null;
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
            var current = head;
            var index = 0;
            while (current != null && !(t.Equals(current.Data)))
            {
                current = current.Next;
                index++;
            };
            if (index < Count) this.RemoveAt(index);
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
            while(current != null)
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