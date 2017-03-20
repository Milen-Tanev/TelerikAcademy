using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Problem12
{
    public class Stack<T> : IEnumerable<T>
    {
        private int capacity = 4;
        private T[] elements = new T[4];
        private int count;
        
        public int Capacity
        {
            get { return this.capacity; }
            protected set
            {
                if (this.capacity <= this.elements.Length)
                {
                    this.capacity = this.elements.Length;
                }
            }
        }

        public T[] Elements
        {
            get { return this.elements; }
        }

        public int Count
        {
            get { return this.count; }
            protected set { this.count = this.elements.Count(el => el != null); }
        }
        
        public void Push(T element)
        {
            if (this.Count == this.Capacity)
            {
                Array.Resize(ref this.elements, this.capacity * 2);
                this.Capacity *= 2;
            }

            this.elements[this.Count] = element;
            this.count++;
        }

        public T Pop()
        {
            var elementToReturn = this.elements[this.Count];
            if (this.count >= 0)
            {
                this.elements[this.Count - 1] = default(T);
            }

            return elementToReturn;
        }

        public T Peek ()
        {
            return this.elements[this.count - 1];
        }

        public IEnumerator<T> GetEnumerator()
        {
            var elementCount = 0;
            while (elementCount < this.Count)
            {
                var element = this.elements[elementCount];
                yield return element;
                elementCount++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
