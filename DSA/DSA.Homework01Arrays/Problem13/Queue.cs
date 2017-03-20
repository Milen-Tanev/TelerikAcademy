
namespace Problem13
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Queue<T> : IEnumerable<T>
    {
        private LinkedList<T> elements = new LinkedList<T>();

        public void Enqueue(T element)
        {
            this.elements.AddLast(element);
        }

        public T Dequeue()
        {
            var elementToReturn = this.elements.First;
            this.elements.RemoveFirst();
            return elementToReturn.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var element = this.elements.First;
            while (element != null)
            {
                yield return element.Value;
                element = element.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
