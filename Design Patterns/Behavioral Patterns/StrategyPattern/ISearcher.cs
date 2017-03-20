namespace StrategyPattern
{
    using System.Collections.Generic;

    interface ISearcher
    {
        int Search(List<int> array, int searchedItem);
    }
}
