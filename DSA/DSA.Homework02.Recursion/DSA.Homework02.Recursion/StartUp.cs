namespace NestedLoops
{
    using System;

    internal class Loops
    {
        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            PrintLoop(arr, 0);
        }

        private static void PrintLoop(int[] arr, int count)
        {
            if (arr.Length <= count)
            {
                Console.WriteLine(string.Join(", ", arr));
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[count] = i;
                    PrintLoop(arr, count + 1);
                }
            }
        }
    }
}