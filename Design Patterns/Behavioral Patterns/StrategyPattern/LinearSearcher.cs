namespace StrategyPattern
{
    using System.Collections.Generic;

    public class LinearSearcher : ISearcher
    {
        public int Search(List<int> array, int searchedItem)
        {
            int length = array.Count;

            for (int i = 0; i < length; i++)
            {
                if (array[i] == searchedItem)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
