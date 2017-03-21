using System;
using System.Collections.Generic;

namespace Problem3.MergeSorter
{
    public class MergeSorter<T>
        where T : IComparable
    {
        public void Sort(IList<T> array, int leftIndex, int rightIndex)
        {
            int length = rightIndex - leftIndex;
            if (length <= 1)
                return;

            int mid = leftIndex + length / 2;

            Sort(array, leftIndex, mid);
            Sort(array, mid, rightIndex);

            var tempValueHolder = new T[length];
            int left = leftIndex;
            int centre = mid;
            for (int i = 0; i < length; i++)
            {
                if (left == mid)
                {
                    tempValueHolder[i] = array[centre++];
                }
                else if (centre == rightIndex)
                {
                    tempValueHolder[i] = array[left++];
                }
                else if (array[centre].CompareTo(array[left]) < 0)
                {
                    tempValueHolder[i] = array[centre++];
                }
                else
                {
                    tempValueHolder[i] = array[left++];
                }
            }

            for (int i = 0; i < length; i++)
            {
                array[leftIndex + i] = tempValueHolder[i];
            }
        }
    }
}
