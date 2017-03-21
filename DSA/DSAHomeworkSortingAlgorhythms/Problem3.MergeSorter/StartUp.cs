using System;

namespace Problem3.MergeSorter
{
    class StartUp
    {
        static void Main()
        {
            var arr = new string[] { "d", "f", "c", "z", "a" };

            var mergeSorter = new MergeSorter<string>();
            mergeSorter.Sort(arr, 0, arr.Length);

            foreach (var str in arr)
            {
                Console.WriteLine(str);
            }
        }
    }
}
