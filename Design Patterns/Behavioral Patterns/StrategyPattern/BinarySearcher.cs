namespace StrategyPattern
{
    using System.Collections.Generic;

    public class BinarySearcher : ISearcher
    {
        public int Search(List<int> array, int searchedItem)
        {
            int min = 0;
            int max = array.Count - 1;

            while (min <= max)
            {
                while(min <= max)
                {
                    int mid = (min + max) / 2;
                    if (searchedItem > array[mid])
                    {
                        min = mid + 1;
                    }
                    else
                    {
                        max = mid - 1;
                    }
                    if (array[mid] == searchedItem)
                    {
                        return mid;
                    }
                }
            }
            return -1;
        }
    }
}
