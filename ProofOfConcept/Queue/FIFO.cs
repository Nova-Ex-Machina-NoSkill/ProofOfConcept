using System;

namespace ProofOfConcept.Queue
{
    public class Fifo<T>
    {
        private T[] fifo;
        private int size;
        private int first;
        private int last;
        private int count;

        public bool IsEmpty { get { return (count == 0); } }

        public bool IsFull { get { return (count == size); } }

        public Fifo() : this(10) { }

        public Fifo(int size)
        {
            this.size = size;
            fifo = new T[size];
            first = 0;
            last = 0;
            count = 0;
        }

        public void Enqueue(T t)
        {
            if (count < size)
            {
                fifo[last] = t;
                last = ++last % size;
                count++;
            }
            else throw new IndexOutOfRangeException();
        }

        public T Dequeue()
        {
            if (count > 0)
            {
                var tmp = fifo[first];
                first = ++first % size;
                count--;
                return tmp;
            }
            else throw new IndexOutOfRangeException();
        }

        public T Peek()
        {
            if (count > 0)
            {
                return fifo[first];
            }
            else throw new IndexOutOfRangeException();
        }
    }
}