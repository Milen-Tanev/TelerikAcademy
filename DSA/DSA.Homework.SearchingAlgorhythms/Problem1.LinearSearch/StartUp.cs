using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.LinearSearch
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            int searchedItem = 3;

            var coll = new SortableCollection<int>();

            Console.WriteLine(coll.LinearSearch(arr, searchedItem));
            Console.WriteLine(coll.BinarySearch(arr, searchedItem));
        }
    }
}
