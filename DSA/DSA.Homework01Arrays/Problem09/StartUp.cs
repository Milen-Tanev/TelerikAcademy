namespace Problem09
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var sequence = new Queue<int>();
            var result = new List<int>();
            sequence.Enqueue(n);

            while (result.Count < 50)
            {
                var currentNum = sequence.Dequeue();
                result.Add(currentNum);

                var seqOne = currentNum + 1;
                var seqTwo = 2 * currentNum + 1;
                var seqThree = currentNum + 2;

                sequence.Enqueue(seqOne);
                sequence.Enqueue(seqTwo);
                sequence.Enqueue(seqThree);
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
