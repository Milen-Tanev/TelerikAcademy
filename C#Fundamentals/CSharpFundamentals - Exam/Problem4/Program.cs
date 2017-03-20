namespace Problem4
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] nums = new string[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = Console.ReadLine();
            }

            string[] mergedNumbers = new string[n - 1];

            for (int i = 0; i < n - 1; i++)
            {
                mergedNumbers[i] = nums[i][1].ToString();
                mergedNumbers[i] += nums[i + 1][0].ToString();
            }

            int[] addedNumbers = new int[n - 1];

            for (int i = 0; i < n-1; i++)
            {
                addedNumbers[i] = int.Parse(nums[i]) + int.Parse(nums[i + 1]);
            }

            StringBuilder sb = new StringBuilder();

            foreach (var str in mergedNumbers)
            {
                sb.Append(str + " ");
            }
            sb.AppendLine();
            foreach (var num in addedNumbers)
            {
                sb.Append(num + " ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
