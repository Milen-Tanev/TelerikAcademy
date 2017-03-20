namespace StrategyPattern
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                array.Add(i);
            }

            ISearcher binSearcher = new BinarySearcher();
            Console.WriteLine($"The index of the searched item is {binSearcher.Search(array, 15)}");

            ISearcher linSearcher = new LinearSearcher();
            Console.WriteLine($"The index of the searched item is {linSearcher.Search(array, 15)}");
        }
    }
}
