using System;

namespace ProofOfConcept.HashTable
{
    public class HashTable<T> where T : new()
    {
        private DataItem[] hashTable;
        private int size;
        private int count;

        public T this[int key] { get { return Search(key); } set { Update(key, value); } }

        public HashTable() : this(10) { }

        public HashTable(int size)
        {
            this.size = size;
            hashTable = new DataItem[size];
            count = 0;
        }

        public void Insert(int key, T value)
        {
            if (count < size)
            {
                var item = new DataItem(key, value);
                var index = hashKey(key);
                while (hashTable[index] != null)
                {
                    index = ++index % size;
                };
                hashTable[index] = item;
                count++;
            }
            else throw new IndexOutOfRangeException();
        }

        public void Update(int key, T value)
        {
            if (count > 0)
            {
                var index = hashKey(key);
                var i = 0;
                while (hashTable[index] != null && i < size)
                {
                    if (hashTable[index].Key == key) hashTable[index].Data = value;
                    else
                    {
                        index = ++index % size;
                        i++;
                    }
                };
            }
            else throw new IndexOutOfRangeException();
        }

        public T Search(int key)
        {
            if (count > 0)
            {
                var index = hashKey(key);
                var i = 0;
                while (hashTable[index] != null && i < size)
                {
                    if (hashTable[index].Key == key) return hashTable[index].Data;
                    else
                    {
                        index = ++index % size;
                        i++;
                    }
                };
                return new T();
            }
            else throw new IndexOutOfRangeException();
        }

        public T Delete(int key)
        {
            if (count > 0)
            {
                var index = hashKey(key);
                var i = 0;
                while (hashTable[index] != null && i < size)
                {
                    if (hashTable[index].Key == key)
                    {
                        var tmp = hashTable[index].Data;
                        hashTable[index] = null;
                        return tmp;
                    }
                    else
                    {
                        index = ++index % size;
                        i++;
                    }
                };
                return new T();
            }
            else throw new IndexOutOfRangeException();
        }

        private int hashKey(int key)
        {
            return key % size;
        }

        private class DataItem
        {
            private int key;
            private T data;

            public int Key { get { return key; } set { key = value; } }
            public T Data { get { return data; } set { data = value; } }

            public DataItem(int key, T data)
            {
                this.key = key;
                this.data = data;
            }
        }
    }
}