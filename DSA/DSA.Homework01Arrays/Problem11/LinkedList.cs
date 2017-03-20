using System;
using System.Collections;
using System.Collections.Generic;

namespace Problem11
{
    public class LinkedList<T> : IEnumerable
    {
        public ListItem<T> FirstElement { get; set; }

        public void Add(ListItem<T> element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("The element cannot be null!");
            }

            if (this.FirstElement == null)
            {
                this.FirstElement = element;
            }
            else
            {
                var lastElement = this.GetLastElement();
                lastElement.NextItem = element;
            }
        }

        public IEnumerator<ListItem<T>> GetEnumerator()
        {
            var element = this.FirstElement;
            while (element != null)
            {
                yield return element;
                element = element.NextItem;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private ListItem<T> GetLastElement()
        {
            var lastElement = this.FirstElement;
            while (lastElement.NextItem != null)
            {
                lastElement = lastElement.NextItem;
            }

            return lastElement;
        }
    }
}
