using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class LinearSearcher : Searcher
    {
        public LinearSearcher(List<int> array, int searchedItem) : base(array, searchedItem)
        {
        }

        protected override int findItem(List<int> arr, int item)
        {
            int length = arr.Count;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
