using System;
using System.Collections.Generic;

namespace Problem2.QuickSorter
{
    public class QuickSorter<T>
        where T : IComparable
    {
        public void Sort(IList<T> array, int leftIndex, int rightIndex)
        {
            IComparable centre = array[(leftIndex + rightIndex) / 2];
            int left = leftIndex;
            int right = rightIndex;

            while (leftIndex <= rightIndex)
            {
                while (array[leftIndex].CompareTo(centre) < 0)
                {
                    leftIndex++;
                }

                while (array[rightIndex].CompareTo(centre) > 0)
                {
                    rightIndex--;
                }

                if (leftIndex <= rightIndex)
                {
                    var temp = array[leftIndex];
                    array[leftIndex] = array[rightIndex];
                    array[rightIndex] = temp;

                    leftIndex++;
                    rightIndex--;
                }
            }

            if (leftIndex < right)
            {
                Sort(array, leftIndex, right);
            }
            if (left < rightIndex)
            {
                Sort(array, left, rightIndex);
            }
        }
    }
}
