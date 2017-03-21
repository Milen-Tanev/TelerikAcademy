using System;
using System.Collections.Generic;

namespace Problem1.LinearSearch
{
    public class SortableCollection<T>
        where T : IComparable
    {
        public int LinearSearch(IList<T> array, T item)
        {
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i].CompareTo(item) == 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public int BinarySearch(IList<T> array, T item)
        {
            int min = 0;
            int max = array.Count - 1;

            do
            {
                int mid = (min + max) / 2;
                if (item.CompareTo(array[mid]) > 0)
                {
                    min = mid + 1;
                }
                else if (item.CompareTo(array[mid]) < 0)
                {
                    max = mid - 1;
                }

                if(item.CompareTo(array[mid]) == 0)
                {
                    return mid;
                }

            } while (min <= max);

            return -1;
        }
    }
}
