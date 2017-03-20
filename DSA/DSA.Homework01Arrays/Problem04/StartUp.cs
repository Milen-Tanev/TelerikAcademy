using System;
using System.Collections.Generic;

namespace Problem04
{
    public class StartUp
    {
        static void Main()
        {
            // Can also be tested in Problem04.Tests
            var list = new List<int> { 1, 2, 3, 4, 4, 4, 5, 6, 7};

            var sequence = GetLongestSubsequence(list);
            foreach (var item in sequence)
            {
                Console.Write($"{item} ");
            }
        }

        public static ICollection<int> GetLongestSubsequence(IList<int> numbers)
        {
            int currentSequence = 1;
            int maxSequence = 0;
            int currentNumber = 0;
            int maxNumber = 0;

            if (numbers.Count == 1)
            {
                maxNumber = numbers[0];
                maxSequence = 1;
            }

            else
            {
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        currentNumber = numbers[i];
                        currentSequence += 1;
                    }
                    else
                    {
                        currentSequence = 1;
                    }

                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                        maxNumber = currentNumber;
                    }
                }
            }

            var subSequence = new List<int>();

            for (int i = 0; i < maxSequence; i++)
            {
                subSequence.Add(maxNumber);
            }

            return subSequence;
        }
    }
}
