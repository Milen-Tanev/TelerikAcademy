namespace Problem2.Duplicates
{
    using System;

    class StartUp
    {
                static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k];

            GenerateVariationsWithRepetitions(arr, k, n, 0);
        }

        static void GenerateVariationsWithRepetitions(int[] arr, int k, int n, int index)
        {
            if (index >= k)
            {
                Console.WriteLine(String.Join(", ", arr));
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    arr[index] = i;
                    GenerateVariationsWithRepetitions(arr, k, n, index + 1);
                }
            }
        }
    }
}