using System;

namespace ProofOfConcept.Stack
{
    public class Stack<T>
    {
        private T[] stack;
        private int size;
        private int index;

        public bool IsEmpty { get { return (index == -1); } }

        public bool IsFull { get { return (index == size - 1); } }

        public Stack() : this(10) { }

        public Stack(int size)
        {
            this.size = size;
            stack = new T[size];
            index = -1;
        }

        public void Push(T t)
        {
            if (index < size - 1)
            {
                index++;
                stack[index] = t;
            }
            else throw new IndexOutOfRangeException();
        }

        public T Pop()
        {
            if (index > -1)
            {
                var tmp = stack[index];
                index--;
                return tmp;
            }
            else throw new IndexOutOfRangeException();
        }

        public T Peek()
        {
            if (index > -1)
            {
                return stack[index];
            }
            else throw new IndexOutOfRangeException();
        }
    }
}