namespace Problem01
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            var numbers = new List<uint>();

            ReadFromConsole(numbers);

            uint sum = GetSum(numbers);
            uint average = GetAverage(numbers);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
        }

        public static void ReadFromConsole(ICollection<uint> numbers)
        {
            // Break works 100% :)
            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                numbers.Add(uint.Parse(input));
            }
        }

        public static uint GetSum(IEnumerable<uint> numbers)
        {
            uint sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        public static uint GetAverage(ICollection<uint> numbers)
        {
            uint sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            uint average = sum / (uint)numbers.Count;

            return average;
        }
    }
}
