using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.QuickSorter
{
    class StartUp
    {
        static void Main()
        {
            var arr = new string[] { "d", "f", "c", "z", "a" };

            var quickSorter = new QuickSorter<string>();
            quickSorter.Sort(arr, 0, arr.Length - 1);

            foreach (var str in arr)
            {
                Console.WriteLine(str);
            }
        }
    }
}
