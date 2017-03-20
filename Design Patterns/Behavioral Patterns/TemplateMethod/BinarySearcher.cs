using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class BinarySearcher : Searcher
    {
        public BinarySearcher(List<int> array, int searchedItem) : base(array, searchedItem)
        {
        }

        protected override int findItem(List<int> arr, int item)
        {
            int min = 0;
            int max = arr.Count - 1;

            while (min <= max)
            {
                while (min <= max)
                {
                    int mid = (min + max) / 2;
                    if (item > arr[mid])
                    {
                        min = mid + 1;
                    }
                    else
                    {
                        max = mid - 1;
                    }
                    if (arr[mid] == item)
                    {
                        return mid;
                    }
                }
            }
            return -1;
        }
    }
}
