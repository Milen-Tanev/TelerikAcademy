namespace Problem2
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            var numbers = new Stack<uint>();

            ReadFromConsole(numbers);
            var reversed = ReverseNumbers(numbers);
            PrintOnConsole(reversed);
        }

        public static void ReadFromConsole(Stack<uint> numbers)
        {
            // First number N, then the numbers for the array
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                numbers.Push(uint.Parse(Console.ReadLine()));
            }
        }

        public static void PrintOnConsole(IEnumerable<uint> listToPrint)
        {
            foreach (var item in listToPrint)
            {
                Console.WriteLine(item);
            }
        }

        public static ICollection<uint> ReverseNumbers(Stack<uint> numbers)
        {
            var reversed = new List<uint>();

            while (numbers.Count > 0)
            {
                reversed.Add(numbers.Pop());
            }

            return reversed;
        }
    }
}
