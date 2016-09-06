using System;

namespace ProofOfConcept.Queue
{
    public class Lifo<T>
    {
        private T[] lifo;
        private int size;
        private int index;

        public bool IsEmpty { get { return (index == -1); } }

        public bool IsFull { get { return (index == size - 1); } }

        public Lifo() : this(10) { }

        public Lifo(int size)
        {
            this.size = size;
            lifo = new T[size];
            index = -1;
        }

        public void Enqueue(T t)
        {
            if (index < size - 1)
            {
                index++;
                lifo[index] = t;
            }
            else throw new IndexOutOfRangeException();
        }

        public T Dequeue()
        {
            if (index > -1)
            {
                var tmp = lifo[index];
                index--;
                return tmp;
            }
            else throw new IndexOutOfRangeException();
        }

        public T Peek()
        {
            if (index > -1)
            {
                return lifo[index];
            }
            else throw new IndexOutOfRangeException();
        }
    }
}