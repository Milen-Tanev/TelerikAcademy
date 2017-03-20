namespace Problem03
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            var numbers = new List<int>();

            ReadFromConsole(numbers);
            SortAscendingly(numbers);
            PrintOnConsole(numbers);
        }

        public static void ReadFromConsole(ICollection<int> numbers)
        {
            // Break works 100% again :)
            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                numbers.Add(int.Parse(input));
            }
        }

        public static void PrintOnConsole(IEnumerable<int> listToPrint)
        {
            foreach (var item in listToPrint)
            {
                Console.WriteLine(item);
            }
        }

        public static void SortAscendingly(IList<int> numbers)
        {
            int length = numbers.Count;

            int temp = numbers[0];

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];

                        numbers[i] = numbers[j];

                        numbers[j] = temp;
                    }
                }
            }
        }
    }
}
