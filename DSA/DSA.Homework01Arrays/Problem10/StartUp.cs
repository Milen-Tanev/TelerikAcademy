namespace ShortestSequenceOfOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class SampleProgram
    {
        private static readonly IList<Func<int, int>> pattern = new List<Func<int, int>>()
        {
            new Func<int, int>(x => 2 * x),
            new Func<int, int>(x => x + 2),
            new Func<int, int>(x => x + 1)
        };

        private static void Main(string[] args)
        {
            int firstMember = int.Parse(Console.ReadLine());
            int requiredMember = int.Parse(Console.ReadLine());
            var calcResult = CalculateMembers(firstMember, requiredMember, pattern);
            Console.WriteLine(string.Format("Result is: {0}", string.Join(", ", calcResult)));
        }

        private static IEnumerable<int> CalculateMembers(int firstMember, int requiredMember, IList<Func<int, int>> pattern)
        {
            int listLength = requiredMember - firstMember / 2;
            var queue = new Queue<List<int>>(listLength);
            var currentList = new List<int>();
            var checkedValues = new HashSet<int>();
            
            currentList.Add(firstMember);
            queue.Enqueue(currentList);

            int currentMember = firstMember;

            while (queue.Count > 0)
            {
                currentList = queue.Dequeue();
                currentMember = currentList.Last();

                if (currentMember < requiredMember && !checkedValues.Contains(currentMember))
                {
                    checkedValues.Add(currentMember);
                    for (int patternIndex = 0; patternIndex < pattern.Count; patternIndex++)
                    {
                        var nextMember = pattern[patternIndex](currentMember);

                        var nextList = new List<int>(currentList);
                        nextList.Add(nextMember);
                        queue.Enqueue(nextList);
                    }
                }

                if (currentMember == requiredMember)
                {
                    return currentList;
                }
            }

            return null;
        }
    }
}