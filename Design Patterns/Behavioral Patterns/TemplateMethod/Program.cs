using System;
using System.Collections.Generic;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new List<int>()
            {
                1, 2, 6, 7, 8, 4, 3, 9, 10, 5
            };

            var searchedItem = 5;

            Searcher searcher = new LinearSearcher(array, searchedItem);
            Console.WriteLine(searcher.Search());

            searcher = new BinarySearcher(array, searchedItem);
            Console.WriteLine(searcher.Search());
        }
    }
}
