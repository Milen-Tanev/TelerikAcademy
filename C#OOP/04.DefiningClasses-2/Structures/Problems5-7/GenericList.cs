namespace Structures
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class GenericList<T>: IEnumerable<T>
        where T :IComparable
    {
        private const int InitialCapacity = 4;
        private int count;
        private int capacity;
        private T[] arr;

        public GenericList(int capacity)
        {
            arr = new T[capacity];
        }

        public int Count
        {
            get
            {
                return this.count;
            }

            set
            {
                this.Count = value;
            }
        }

        public int Capacity
        {
            set
            {
                this.capacity = value;
            }
        }

        public T[] Arr
        {
            get
            {
                return this.arr;
            }

            set
            {
                this.arr = value;
            }
        }


        public void Add(T item)
        {
            if (this.arr.Length < capacity)
            {
                this.arr[this.Count] = item;
                this.Count++;
            }
            else
            {
                capacity *= 2;
                Array previousArr = this.arr;
                this.arr = new T[this.capacity];
                Array.Copy(previousArr, this.arr, this.Count);
            }
        }


        

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in arr)
            {
                if (item == null)
                {
                    break;
                }

                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
