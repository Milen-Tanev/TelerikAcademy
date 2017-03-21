using System;
using System.Collections.Generic;

namespace DSAHomeworkSortingAlgorhythms
{
    public class SelectionSorter<T>
        where T : IComparable
    {
        public void Sort(IList<T> arr)
        {
            int minPosition = 0;

            for (int i = 0; i < arr.Count - 1; i++)
            {
                minPosition = i;

                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (arr[j].CompareTo(arr[minPosition]) < 0)
                    {
                        minPosition = j;
                    }
                }

                if (minPosition != i)
                {
                    var temp = arr[i];
                    arr[i] = arr[minPosition];
                    arr[minPosition] = temp;
                }
            }
        }
    }
}
