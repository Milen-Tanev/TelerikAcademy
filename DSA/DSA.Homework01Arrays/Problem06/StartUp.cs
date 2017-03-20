namespace Problem06
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var sequence = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            // Find the occurances of each number
            var occuranceOfEachValue = new Dictionary<int, int>();
            for (int i = 0; i < sequence.Count; i++)
            {
                if (!occuranceOfEachValue.Keys.Contains(sequence[i]))
                {
                    occuranceOfEachValue.Add(sequence[i], 1);
                }
                else
                {
                    int value = occuranceOfEachValue[sequence[i]] + 1;
                    occuranceOfEachValue[sequence[i]] = value;
                }
            }

            var numbersWithEvenOccurances = new List<int>();
            for (int i = 0; i < sequence.Count; i++)
            {
                foreach (var item in occuranceOfEachValue)
                {
                    if (item.Value % 2 == 0 && item.Key == sequence[i])
                    {
                        numbersWithEvenOccurances.Add(item.Key);
                    }
                }
            }

            Console.Write("{ ");
            foreach (var item in numbersWithEvenOccurances)
            {
                Console.Write($"{item} ");
            }
            Console.Write("}");
        }
    }
}
