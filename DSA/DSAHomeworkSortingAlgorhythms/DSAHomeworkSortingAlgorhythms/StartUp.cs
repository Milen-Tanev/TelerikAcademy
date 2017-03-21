using System;

namespace DSAHomeworkSortingAlgorhythms
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var arr = new string[] { "d", "f", "c", "z", "a" };

            var selectionSorter = new SelectionSorter<string>();
            selectionSorter.Sort(arr);

            foreach (var str in arr)
            {
                Console.WriteLine(str);
            }
        }
    }
}
